using Microsoft.UI.Xaml.Controls;

using Twintail.ViewModels;

namespace Twintail.Views;

public sealed partial class PgrPage : Page
{
    public PgrViewModel ViewModel
    {
        get;
    }

    public PgrPage()
    {
        ViewModel = App.GetService<PgrViewModel>();
        InitializeComponent();
    }
}
