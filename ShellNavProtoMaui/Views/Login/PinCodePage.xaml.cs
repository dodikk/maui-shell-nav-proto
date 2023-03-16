using CommunityToolkit.Mvvm.Input;


namespace ShellNavProtoMaui.Views.Login;


public partial class PinCodePage : ContentPage
{
    public PinCodePage()
    {
        InitializeComponent();
    }

    [RelayCommand]
    private void SubmitButtonTapped()
    {
        _ = Shell.Current.GoToAsync("//Main");
    }
}
