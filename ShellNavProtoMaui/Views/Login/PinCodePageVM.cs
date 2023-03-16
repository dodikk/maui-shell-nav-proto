using System;
using CommunityToolkit.Mvvm.ComponentModel;


namespace ShellNavProtoMaui.Views.Login
{
    [QueryProperty(name: "ShouldDisplayTopToolbar", queryId: "with_top_panel")]
    public partial class PinCodePageVM: ObservableObject
    {
        [ObservableProperty]
        private bool _shouldDisplayTopToolbar;
    }
}

