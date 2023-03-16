using CommunityToolkit.Mvvm.Input;

namespace ShellNavProtoMaui.Views.Tabs.CoinTransaction;

public partial class TransactionResultPage : ContentPage
{
	public TransactionResultPage()
	{
		InitializeComponent();
	}

    [RelayCommand]
    private void SubmitButtonTapped()
    {
        // Note: [alex-d] [maui.shell] the |///| prefix instructs to search back
        //       until the page named |Main| is found
        // -
        _ = Shell.Current.GoToAsync("///Main");
    }
}
