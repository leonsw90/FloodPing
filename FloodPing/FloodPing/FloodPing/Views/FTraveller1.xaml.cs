using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FloodPing.Views
{
    public partial class FTraveller1 : ContentPage
    {
        public FTraveller1()
        {
            this.BackgroundImage = "a2.jpg";
            BindingContext = this;

            InitializeComponent();

            this.Title = "Journey Planner";
        }

        public void LaunchFTraveller2(object sender, EventArgs args)
        {
            // Launch Emergency App
            Navigation.PushAsync(new Views.FTraveller2());
        }



    }
}
