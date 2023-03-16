namespace ShellNavProtoMaui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        _appShell = new AppShell();
        MainPage = _appShell;
        _ = _appShell.OpenRootPageAsync();
    }

	private AppShell _appShell;
}

