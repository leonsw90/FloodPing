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

            Title = "Show Statistics";
        }

        public void LaunchGraphview(object sender, EventArgs args)
        {
            // Launch Emergency App
            Navigation.PushAsync(new Views.GraphShowing());
        }
    }
}
