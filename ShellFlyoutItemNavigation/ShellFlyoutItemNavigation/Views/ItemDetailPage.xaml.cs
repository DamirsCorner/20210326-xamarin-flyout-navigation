using ShellFlyoutItemNavigation.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ShellFlyoutItemNavigation.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}