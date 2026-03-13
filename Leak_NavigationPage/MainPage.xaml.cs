namespace Leak_NavigationPage;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        MemoryToolkit.Maui.LeakMonitorBehavior.SetCascade(this, true);
    }

    private void OnCounterClicked(object? sender, EventArgs e)
    {
        Navigation.PushModalAsync(new NavigationPage(new MainPage()));
    }
}