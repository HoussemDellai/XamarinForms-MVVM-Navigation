
using MvvmApp.Interfaces;
using MvvmApp.Services;
using Xamarin.Forms;

namespace MvvmApp.ViewModels
{
    public class MainViewModel
    {
        private readonly INavigationService _navigationService;

        public Command NavigateCommand { get; private set; }
        public Command NavigateBackCommand { get; private set; }

        public MainViewModel()
        {
            NavigateCommand = new Command(() =>
            {
                var navigationService = new NavigationService();

                navigationService.NavigateToSecondPage();
            });

            NavigateBackCommand = new Command(() =>
            {
                var navigationService = new NavigationService();

                navigationService.NavigateBack();
            });
        }

        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            NavigateCommand = new Command(() =>
            {
                _navigationService.NavigateToSecondPage();
            });
        }
    }
}
