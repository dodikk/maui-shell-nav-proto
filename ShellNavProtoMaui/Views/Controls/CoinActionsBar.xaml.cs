using CommunityToolkit.Mvvm.Input;


namespace ShellNavProtoMaui.Views.Controls;


public partial class CoinActionsBar : ContentView
{
	public CoinActionsBar()
	{
		InitializeComponent();
	}

	[RelayCommand]
	private void OnReceiveButtonTapped()
	{
        _ = Shell.Current.GoToAsync("ReceiveCoinPage");
	}

    [RelayCommand]
    private void OnSendButtonTapped()
    {
        _ = Shell.Current.GoToAsync("SendCoinPage");
    }

    [RelayCommand]
    private void OnConvertButtonTapped()
    {
        _ = Shell.Current.GoToAsync("ConvertCoinPage");
    }
}
