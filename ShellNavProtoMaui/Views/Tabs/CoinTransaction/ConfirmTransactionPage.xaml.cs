using CommunityToolkit.Mvvm.Input;


namespace ShellNavProtoMaui.Views.Tabs.CoinTransaction;


public partial class ConfirmTransactionPage : ContentPage
{
	public ConfirmTransactionPage()
	{
		InitializeComponent();
	}

    [RelayCommand]
    private void SubmitButtonTapped()
    {
        _ = Shell.Current.GoToAsync("TransactionResultPage");
    }
}
