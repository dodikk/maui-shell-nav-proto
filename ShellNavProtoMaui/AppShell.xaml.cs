using ShellNavProtoMaui.Views.Login;
using ShellNavProtoMaui.Views.Tabs;

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


        // TODO: [alex-d] maybe just "LoginPage" instead of path with separators
        // -
        Routing.RegisterRoute(
              route: "login/WelcomePage/LoginPage"
            , type: typeof(PinCodePage)
        );

        Routing.RegisterRoute(
              route: nameof(ActivityPage)
            , type: typeof(PinCodePage)
        );

        Routing.RegisterRoute(
              route: nameof(SettingsPage)
            , type: typeof(SettingsPage)
        );
    }
}

