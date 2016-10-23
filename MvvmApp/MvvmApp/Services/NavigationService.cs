using System.Linq;
using MvvmApp.Interfaces;
using MvvmApp.Views;
using Xamarin.Forms;

namespace MvvmApp.Services
{
    public class NavigationService : INavigationService
    {
        public async void NavigateToSecondPage()
        {
            var currentPage = GetCurrentPage();

            await currentPage.Navigation.PushModalAsync(new SecondPage());
        }

        public async void NavigateBack()
        {
            var currentPage = GetCurrentPage();

            await currentPage.Navigation.PopModalAsync();
        }

        private Page GetCurrentPage()
        {
            var currentPage = Application.Current.MainPage.Navigation.NavigationStack.LastOrDefault();

            return currentPage;
        }
    }
}
