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
            this.BackgroundImage = "a4.jpg";
            BindingContext = this;

            InitializeComponent();
        }

        public void LaunchFTraveller4(object sender, EventArgs args)
        {
            // Launch Emergency App
            Navigation.PushAsync(new Views.FTraveller4());
        }

    }
}
