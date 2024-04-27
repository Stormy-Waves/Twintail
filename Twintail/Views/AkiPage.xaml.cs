using Microsoft.UI.Xaml.Controls;

using Twintail.ViewModels;

namespace Twintail.Views;

public sealed partial class AkiPage : Page
{
    public AkiViewModel ViewModel
    {
        get;
    }

    public AkiPage()
    {
        ViewModel = App.GetService<AkiViewModel>();
        InitializeComponent();
    }
}
