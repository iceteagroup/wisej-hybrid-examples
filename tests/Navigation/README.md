# Navigation regressions

Run from the examples repository:

```powershell
dotnet run --project tests/Navigation/Navigation.Tests.csproj
```

The console project links the actual sample `MainPage.cs`. Small UI doubles expose
view events, front/back ordering, and independently completed appearance and
disappearance animations; they do not implement a navigation stack. Tests cover
the 250–500 ms transition gap, root/missing targets, repeated back navigation,
multi-view pop-to (hidden intermediates dispose without animation callbacks),
and events from hidden or not-yet-disposed outgoing views.

To check an older source file with the same cases, pass an absolute path:

```powershell
dotnet run --project tests/Navigation/Navigation.Tests.csproj -p:NavigationSource="C:/baseline/MainPage.cs"
```

This reproduces algorithm failures under controlled event ordering. It does not
establish that an older deployed runtime produced that ordering, or replace a
real-device check of animation timing, rendering, and event delivery.
