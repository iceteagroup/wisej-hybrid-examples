// Test doubles model the view events and animation completions used by MainPage.
// Navigation history and decisions are implemented only by the linked production file.
namespace Wisej.Web
{
    public enum DockStyle { Fill }

    public class Control
    {
        private Control parent;
        public List<Control> Controls { get; } = new();
        public DockStyle Dock { get; set; }
        public bool Visible { get; private set; } = true;
        public bool IsDisposed { get; private set; }
        public int DisposeCount { get; private set; }

        public Control Parent
        {
            get => parent;
            set
            {
                parent?.Controls.Remove(this);
                parent = value;
                parent?.Controls.Add(this);
            }
        }

        public void BringToFront()
        {
            if (Parent == null) return;
            Parent.Controls.Remove(this);
            Parent.Controls.Insert(0, this);
        }

        public void SendToBack()
        {
            if (Parent == null) return;
            Parent.Controls.Remove(this);
            Parent.Controls.Add(this);
        }

        public void Show() => Visible = true;
        public void Hide() => Visible = false;
        public void Dispose()
        {
            DisposeCount++;
            IsDisposed = true;
            Parent = null;
        }
    }

    public class Page : Control { }
}

namespace HybridLocal
{
    public partial class MainPage
    {
        private void InitializeComponent() { }
        public void LoadForTest() => MainPage_Load(this, EventArgs.Empty);
    }
}

namespace HybridLocal.Views
{
    public class ViewBase : Wisej.Web.Control
    {
        private readonly Queue<Action> completions = new();
        public bool Busy { get; private set; }
        public int PendingTransitions => completions.Count;
        public event EventHandler<Type> PushView;
        public event EventHandler<Type> PopToView;
        public event EventHandler PopView;
        public void TryPushView(Type type) => PushView?.Invoke(this, type);
        public void TryPopToView(Type type) => PopToView?.Invoke(this, type);
        public void TryPopView() => PopView?.Invoke(this, EventArgs.Empty);

        public void PushAppear()
        {
            Busy = true;
            BringToFront();
            completions.Enqueue(AppearEnd);
        }

        public void PushDisappear()
        {
            Busy = true;
            completions.Enqueue(() => { Hide(); Busy = false; });
        }

        public void PopAppear()
        {
            Busy = true;
            Show();
            completions.Enqueue(AppearEnd);
        }

        public void PopDisappear()
        {
            Busy = true;
            SendToBack();
            completions.Enqueue(Dispose);
        }

        private void AppearEnd() { BringToFront(); Busy = false; }

        // Tests complete 250 ms appearances independently of 500 ms disappearances.
        public void CompleteTransition()
        {
            if (completions.Count == 0)
                throw new InvalidOperationException("No pending animation.");
            completions.Dequeue()();
        }
    }

    public class LoginView : ViewBase { }
    public class HomeView : ViewBase { }
    public class SettingsView : ViewBase { }
    public class MissingView : ViewBase { }
}
