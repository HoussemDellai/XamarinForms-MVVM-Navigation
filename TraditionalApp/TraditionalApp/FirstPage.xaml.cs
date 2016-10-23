using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TraditionalApp
{
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private async void Navigate_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SecondPage());
        }
    }
}
