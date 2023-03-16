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
        //_ = Shell.Current.GoToAsync("PinCodePage");
        //_ = Shell.Current.GoToAsync($"PinCodePage?with_top_panel={true}");

        _ = Shell.Current.GoToAsync(
              state: "PinCodePage"
            , animate: true
            , parameters: new Dictionary<string, object>()
              {
                  { "with_top_panel", true }
              });
    }
}
