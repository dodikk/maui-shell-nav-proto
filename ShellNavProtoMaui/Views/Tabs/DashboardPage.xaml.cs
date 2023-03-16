using CommunityToolkit.Mvvm.Input;


namespace ShellNavProtoMaui.Views.Tabs;


public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		InitializeComponent();
	}

	[RelayCommand]
	private void OnSettingsButtonTapped()
	{
		_ = Shell.Current.GoToAsync("SettingsPage");
	}
}
