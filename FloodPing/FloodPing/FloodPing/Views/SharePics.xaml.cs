using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FloodPing.Views
{
    public partial class SharePics : ContentPage
    {
        public SharePics()
        {
            InitializeComponent();
            Title = "Share Pictures";
        }
        public void HeavyTag(object sender, EventArgs args)
        {
            // Launch Emergency App
            Navigation.PushAsync(new Views.HeavyImage());
        }
        public void MediumTag(object sender, EventArgs args)
        {
            // Launch Emergency App
            Navigation.PushAsync(new Views.MediumImage());
        }
        public void LightTag(object sender, EventArgs args)
        {
            // Launch Emergency App
            Navigation.PushAsync(new Views.LightImage());
        }
        public void Facebooked(object sender, EventArgs args)
        {
            // Launch Emergency App
            Navigation.PushAsync(new Views.Facebook());
        }


    }
}
