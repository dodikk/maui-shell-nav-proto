using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;


namespace ShellNavProtoMaui.Views.Login;


public partial class WelcomePage : ContentPage
{
	public WelcomePage()
	{
		InitializeComponent();
	}

	[RelayCommand]
	private void OnLoginButtonTapped()
	{
		_ = Shell.Current.GoToAsync("LoginPage");
	}
}
