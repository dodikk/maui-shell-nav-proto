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

    public async Task OpenRootPageAsync()
    {
        //await _navigationService.InitializeAsync();

        // TODO: [alex-d] maybe replace with other pages
        // * await Shell.Current.GoToAsync("//PinCodePage");
        // * await Shell.Current.GoToAsync("//Main");
        // -
        await Shell.Current.GoToAsync("//WelcomePage");



        // Note: [alex-d] these are same
        // * await Shell.Current.GoToAsync("//Main");
        // * await Shell.Current.GoToAsync("//Main/TabDashboard");
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
              // Note: [alex-d] a version with separators did not quite work for me
              //       "LoginPage" instead of "/login/LoginPage" 
              // -
              route: nameof(LoginPage)
            , type: typeof(LoginPage)
        );

        Routing.RegisterRoute(
              // Note: [alex-d] without RegisterRoute() the transision does not happen
              //       when we have only xaml entry
              // -
              route: nameof(PinCodePage)
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

