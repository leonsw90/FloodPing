using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FloodPing.Views
{
    public partial class FTraveller2 : ContentPage
    {
        public FTraveller2()
        {
            this.BackgroundImage = "mroute.jpg";
            BindingContext = this;

            InitializeComponent();
            this.Title = "Journey Planner";
        }

        public void LaunchFTraveller3(object sender, EventArgs args)
        {
            // Launch Emergency App
            Navigation.PushAsync(new Views.FTraveller3());

        }

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
