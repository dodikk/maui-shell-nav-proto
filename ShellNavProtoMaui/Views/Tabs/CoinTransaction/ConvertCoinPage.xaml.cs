using CommunityToolkit.Mvvm.Input;


namespace ShellNavProtoMaui.Views.Tabs.CoinTransaction;


public partial class ConvertCoinPage : ContentPage
{
	public ConvertCoinPage()
	{
		InitializeComponent();
	}

    [RelayCommand]
    private void SubmitButtonTapped()
    {
        _ = Shell.Current.GoToAsync("ConfirmTransactionPage");
    }
}
