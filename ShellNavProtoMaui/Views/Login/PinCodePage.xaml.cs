using AndroidX.Lifecycle;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace ShellNavProtoMaui.Views.Login;

// Note: [alex-d] these can be added either to VM or to ContentPage
//       using VM to try ObservableProperty from CommunityToolkit 
// -
// [QueryProperty(name: "ShouldDisplayTopToolbar", queryId: "with_top_panel")]
// [QueryProperty(name: nameof(ShouldDisplayTopToolbar), queryId: "with_top_panel")]

public partial class PinCodePage : ContentPage
{
    public PinCodePage(PinCodePageVM viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = viewModel;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        System.Console.WriteLine("[viewDidAppear] PinCodePage");
    }

    [RelayCommand]
    private void SubmitButtonTapped()
    {
        _ = Shell.Current.GoToAsync("//Main");
    }

    private readonly PinCodePageVM _viewModel;
}


