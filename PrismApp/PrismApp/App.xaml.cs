using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism.Unity;
using PrismApp.Views;
using Xamarin.Forms;

namespace PrismApp
{
    public partial class App : PrismApplication
    {
        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MainPage?title=Xamarin");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<FirstPage>();
        }
    }
}
