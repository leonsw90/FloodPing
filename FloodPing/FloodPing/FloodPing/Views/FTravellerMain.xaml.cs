using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FloodPing.Views
{
    public partial class FTravellerMain : ContentPage
    {
        public FTravellerMain()
        {
            InitializeComponent();

            // Add the map background image
            this.BackgroundImage = "a1.png";
            BindingContext = this;

            this.Title = "Journey Planner";
            
        }

        public void FTraveller1(object sender, EventArgs args)
        {
            // Launch Emergency App
            Navigation.PushAsync(new Views.FTraveller1());
        }
    }
}
