using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FloodPing.Views
{
    public partial class FTraveller4 : ContentPage
    {
        public FTraveller4()
        {
            this.BackgroundImage = "a5.jpg";
            BindingContext = this;


            InitializeComponent();
        }

        public void LaunchFTraveller3(object sender, EventArgs args)
        {
            // Launch Emergency App
            Navigation.PushAsync(new Views.FTraveller4());
        }
    }
}
