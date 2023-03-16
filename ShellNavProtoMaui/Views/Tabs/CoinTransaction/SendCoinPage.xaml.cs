using CommunityToolkit.Mvvm.Input;


namespace ShellNavProtoMaui.Views.Tabs.CoinTransaction;


public partial class SendCoinPage : ContentPage
{
	public SendCoinPage()
	{
		InitializeComponent();
	}

    [RelayCommand]
    private void SubmitButtonTapped()
    {
        _ = Shell.Current.GoToAsync("ConfirmTransactionPage");
    }
}
