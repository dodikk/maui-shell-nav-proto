using ShellNavProtoMaui.Views.Login;


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

        //await Shell.Current.GoToAsync("//login/PinCodePage");
        // await Shell.Current.GoToAsync("//Main/TabDashboard");
    }

    private static void InitializeRouting()
    {
        Routing.RegisterRoute(
              route: "login/WelcomePage/LoginPage"
            , type: typeof(PinCodePage)
        );
            
    }
}

