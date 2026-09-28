using HybridLocal;
using HybridLocal.Views;

var tests = new (string Name, Action Run)[]
{
    ("Return during the 250–500 ms transition gap", TransitionGap),
    ("Root pop and missing target preserve the current view", InvalidPops),
    ("Repeated back navigation ignores visual control ordering", RepeatedBack),
    ("Pop-to removes every intermediate view once", PopToRoot),
    ("Events from hidden or outgoing views are ignored", StaleEvents)
};
int failures = 0;
foreach (var test in tests)
{
    try { test.Run(); Console.WriteLine($"PASS {test.Name}"); }
    catch (Exception error)
    {
        failures++;
        Console.WriteLine($"FAIL {test.Name}: {error.GetType().Name}: {error.Message}");
    }
}
Console.WriteLine($"{tests.Length - failures}/{tests.Length} navigation regressions passed.");
return failures == 0 ? 0 : 1;

static (MainPage Page, LoginView Login) Start()
{
    var page = new MainPage();
    page.LoadForTest();
    var login = page.Controls.OfType<LoginView>().Single();
    login.CompleteTransition();
    return (page, login);
}

static T Push<T>(MainPage page, ViewBase previous) where T : ViewBase
{
    previous.TryPushView(typeof(T));
    var next = page.Controls.OfType<T>().Single();
    next.CompleteTransition();
    previous.CompleteTransition();
    AssertFront(page, next);
    return next;
}

static void TransitionGap()
{
    var (page, login) = Start();
    login.TryPushView(typeof(HomeView));
    var home = page.Controls.OfType<HomeView>().Single();
    home.CompleteTransition(); // 250 ms: Login's disappearance is still pending.
    home.TryPopToView(typeof(LoginView));
    Check(home.PendingTransitions == 0 && login.PendingTransitions == 1,
        "A return must wait until both sides of the push finish.");
    login.CompleteTransition(); // 500 ms
    home.TryPopToView(typeof(LoginView));
    login.CompleteTransition();
    home.CompleteTransition();
    AssertFront(page, login);
    Check(home.DisposeCount == 1, "The outgoing Home must be disposed exactly once.");
}

static void InvalidPops()
{
    var (page, login) = Start();
    login.TryPopView();
    Check(login.PendingTransitions == 0, "Popping the root must not animate or dispose it.");
    login.TryPopToView(typeof(MissingView));
    login.TryPopToView(typeof(LoginView));
    Check(login.PendingTransitions == 0, "Missing/current targets must leave the root intact.");
    var home = Push<HomeView>(page, login);
    home.TryPopToView(typeof(MissingView));
    Check(home.PendingTransitions == 0, "A missing target must not remove the current view.");
    AssertFront(page, home);
}

static void RepeatedBack()
{
    var (page, login) = Start();
    for (int i = 0; i < 4; i++)
    {
        var home = Push<HomeView>(page, login);
        var settings = Push<SettingsView>(page, home);
        // Visual order is deliberately different from navigation history.
        login.BringToFront();
        home.SendToBack();
        settings.TryPopView();
        home.CompleteTransition();
        settings.CompleteTransition();
        AssertFront(page, home);
        Check(settings.DisposeCount == 1, "Back must dispose Settings exactly once.");
        home.TryPopView();
        login.CompleteTransition();
        home.CompleteTransition();
        AssertFront(page, login);
        Check(page.Controls.Count == 1 && home.DisposeCount == 1, "Back must restore only the root.");
    }
}

static void PopToRoot()
{
    var (page, login) = Start();
    var home = Push<HomeView>(page, login);
    var settings = Push<SettingsView>(page, home);
    settings.TryPopToView(typeof(LoginView));
    Check(home.IsDisposed && home.DisposeCount == 1 && home.PendingTransitions == 0,
        "A hidden intermediate view must be disposed without waiting for an animation event.");
    Check(!settings.IsDisposed && settings.PendingTransitions == 1,
        "Only the visible outgoing view should animate before disposal.");
    login.CompleteTransition();
    settings.CompleteTransition();
    AssertFront(page, login);
    Check(page.Controls.Count == 1 && home.DisposeCount == 1 && settings.DisposeCount == 1,
        "Pop-to must remove and dispose all intermediate views once.");
}

static void StaleEvents()
{
    var (page, login) = Start();
    var home = Push<HomeView>(page, login);
    login.TryPushView(typeof(SettingsView));
    login.TryPopView();
    login.TryPopToView(typeof(LoginView));
    Check(page.Controls.Count == 2 && home.PendingTransitions == 0,
        "A hidden ancestor must not navigate.");
    home.TryPopView();
    login.CompleteTransition(); // Home's 500 ms disposal has not fired yet.
    home.TryPushView(typeof(SettingsView));
    home.TryPopView();
    home.TryPopToView(typeof(LoginView));
    Check(page.Controls.Count == 2 && login.PendingTransitions == 0,
        "A removed view awaiting disposal must not navigate.");
    home.CompleteTransition();
    AssertFront(page, login);
}

static void AssertFront(MainPage page, ViewBase expected)
{
    Check(page.Controls.FirstOrDefault() == expected && expected.Visible && !expected.IsDisposed,
        $"Expected visible, live {expected.GetType().Name} at the front.");
}

static void Check(bool condition, string message)
{
    if (!condition) throw new InvalidOperationException(message);
}
