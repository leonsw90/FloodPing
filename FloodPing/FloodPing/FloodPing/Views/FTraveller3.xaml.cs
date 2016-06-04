using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FloodPing.Views
{
    public partial class FTraveller3 : ContentPage
    {
        public FTraveller3()
        {
            this.BackgroundImage = "routemap.png";
            BindingContext = this;

            InitializeComponent();
            this.Title = "Route Preview";
        }

        //public void LaunchFTraveller4(object sender, EventArgs args)
        //{
        //    // Launch Emergency App
        //    Navigation.PushAsync(new Views.FTraveller4());
        //}

        public void GoToMainMenu(object sender, EventArgs args)
        {
            // Launch Emergency Message Form
            Navigation.PushAsync(new Views.MainPage());

        }

        public void ViewSD(object sender, EventArgs args)
        {
            // Launch Emergency Message Form
            Navigation.PushAsync(new Views.ViewSavedDestinations());

        }

    }
}
