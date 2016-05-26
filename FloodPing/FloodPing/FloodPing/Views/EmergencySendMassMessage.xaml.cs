using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;

namespace FloodPing.Views
{
    public partial class EmergencySendMassMessage : ContentPage
    {
        public EmergencySendMassMessage()
        {
            // Add the map background image
            this.BackgroundImage = "map.png";
            BindingContext = this;

            Random rand = new Random();
            
            // Dynamically generate dots on the map.
            // The real map would get GPS location from the straded travellers.

            Button button1 = new Button
            {
                StyleId = (rand.Next()).ToString(),
                Image = "spot.png",
                BorderWidth = 0,
                BackgroundColor = Color.Transparent,
                WidthRequest = 40,
                HeightRequest = 40,
                Scale = 3,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Button button2 = new Button
            {
                StyleId = (rand.Next()).ToString(),
                Image = "spot.png",
                BorderWidth = 0,
                BackgroundColor = Color.Transparent,
                WidthRequest = 40,
                HeightRequest = 40,
                Scale = 2,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            button1.Clicked += OnButtonClicked;
            button2.Clicked += OnButtonClicked;

            InitializeComponent();

            this.Content = new StackLayout
            {
                Children =
                {
                    button1,
                    button2
                }
            };

        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", ((Button)sender).StyleId, "OK");
        }

        public void OnClickSendMassMessage(object sender, EventArgs args)
        {
            // Launch Emergency Message Form
            Navigation.PushAsync(new Views.EmergencySendMessageForm());

        }

        public void OnClickNotifyControlCentre(object sender, EventArgs args)
        {

        }
        

    }
}
