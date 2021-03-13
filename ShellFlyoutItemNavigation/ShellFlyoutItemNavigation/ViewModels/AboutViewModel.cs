using ShellFlyoutItemNavigation.Views;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ShellFlyoutItemNavigation.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            OpenItemsCommand = new Command(async () => await Shell.Current.GoToAsync($"//{nameof(ItemsPage)}"));
        }

        public ICommand OpenWebCommand { get; }

        public ICommand OpenItemsCommand { get; }
    }
}