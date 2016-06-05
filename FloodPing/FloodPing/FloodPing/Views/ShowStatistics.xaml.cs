using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FloodPing.Views
{
    public partial class ShowStatistics : ContentPage
    {
        public ShowStatistics()
        {
            InitializeComponent();
            this.BackgroundColor = Color.Black;

            Title = "Show Statistics";
        }

        public void g1fun(object sender, EventArgs args)
        {
            // Launch Emergency App
            Navigation.PushAsync(new Views.graph1());
        }
        public void g2fun(object sender, EventArgs args)
        {
            // Launch Emergency App
            Navigation.PushAsync(new Views.graph2());
        }
        public void g3fun(object sender, EventArgs args)
        {
            // Launch Emergency App
            Navigation.PushAsync(new Views.graph3());
        }
        public void g4fun(object sender, EventArgs args)
        {
            // Launch Emergency App
            Navigation.PushAsync(new Views.graph4());
        }

    }
}
