using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace PrismApp.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {

        private INavigationService _navigationService;
        private string _title = "Hello";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand NavigateToFirstPageCommand { get; private set; }

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            NavigateToFirstPageCommand = new DelegateCommand(NavigateToFirstPage);
        }

        private async void NavigateToFirstPage()
        {
            var parameters = new NavigationParameters();

            parameters.Add("name", "First Page");

            await _navigationService.NavigateAsync("FirstPage", parameters);
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
            {
                Title = (string)parameters["title"];
            }
        }
    }
}
