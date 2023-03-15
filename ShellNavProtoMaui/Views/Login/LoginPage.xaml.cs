using CommunityToolkit.Mvvm.Input;


namespace ShellNavProtoMaui.Views.Login;


public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}


	[RelayCommand]
    private void SubmitButtonTapped()
	{
        _ = Shell.Current.GoToAsync("login/WelcomePage/LoginPage/PinCode");
    }
}
