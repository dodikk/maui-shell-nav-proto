using ShellNavProtoMaui.Views.Login;
using ShellNavProtoMaui.Views.Tabs;
using ShellNavProtoMaui.Views.Tabs.CoinTransaction;


namespace ShellNavProtoMaui;


public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeRouting();
        InitializeComponent();
    }


    protected override async void OnHandlerChanged()
    {
        // TODO: [alex-d] do we need that?
        // -

        base.OnHandlerChanged();

        if (Handler is not null)
        {
            await OpenRootPageAsync();
            //await _navigationService.InitializeAsync();
        }
    }

    private async Task OpenRootPageAsync()
    {
        //await _navigationService.InitializeAsync();

        // TODO: [alex-d] maybe replace with |//login/PinCodePage|
        // -
        await Shell.Current.GoToAsync("//login/WelcomePage");
        // await Shell.Current.GoToAsync("//Main");


        // ???
        // await Shell.Current.GoToAsync("//login/PinCodePage");
        // await Shell.Current.GoToAsync("//Main/TabDashboard");

    }

    private static void InitializeRouting()
    {
        // note: [alex-d] root pages registered in xaml
        // ---
        // * WelcomePage - "//login/WelcomePage"
        // * PinCodePage - "//login/PinCodePage"
        // 
        // * Main        - <TabBar Route="Main">
        // * Main/TabDashboard
        // * Main/TabWallets
        // * Main/TabOthers
        // -


        // login pages
        // -
        Routing.RegisterRoute(
              // TODO: [alex-d] maybe just "LoginPage" instead of path with separators
              // -
              route: "login/WelcomePage/LoginPage"
            , type: typeof(PinCodePage)
        );


        // TabBar pages
        // -
        Routing.RegisterRoute(
              route: nameof(ActivityPage)
            , type: typeof(ActivityPage)
        );

        Routing.RegisterRoute(
              route: nameof(SettingsPage)
            , type: typeof(SettingsPage)
        );


        // Coin transaction pages
        // -
        Routing.RegisterRoute(
              route: nameof(ReceiveCoinPage)
            , type: typeof(ReceiveCoinPage)
        );

        Routing.RegisterRoute(
              route: nameof(SendCoinPage)
            , type: typeof(SendCoinPage)
        );

        Routing.RegisterRoute(
              route: nameof(ConvertCoinPage)
            , type: typeof(ConvertCoinPage)
        );

        Routing.RegisterRoute(
              route: nameof(ConfirmTransactionPage)
            , type: typeof(ConfirmTransactionPage)
        );

        Routing.RegisterRoute(
              route: nameof(TransactionResultPage)
            , type: typeof(TransactionResultPage)
        );
    }
}

