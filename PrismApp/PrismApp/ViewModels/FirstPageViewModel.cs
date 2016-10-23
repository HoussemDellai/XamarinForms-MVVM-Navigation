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
    public class FirstPageViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;

        public DelegateCommand NavigateBackCommand { get; private set; }

        public FirstPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            NavigateBackCommand = new DelegateCommand(async() => 
                await  _navigationService.GoBackAsync());
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("name"))
            {
                var name = (string)parameters["name"];
            }
        }
    }
}
