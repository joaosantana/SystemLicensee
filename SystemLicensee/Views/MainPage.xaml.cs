using System;

using SystemLicensee.ViewModels;

using Windows.UI.Xaml.Controls;

namespace SystemLicensee.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
