using FloodPing.ViewModels;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
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

            BindingContext = new SafeRouteViewModel(SimpleIoc.Default.GetInstance<INavigationService>());

            // Setup messaging centre to handle message from the viewModel.
            MessagingCenter.Subscribe<SafeRouteViewModel, string>(this, "Destination Saved", (sender, arg) =>
            {
                DisplayAlert("Destination Saved", arg, "OK");


            });
        }




        public void FTraveller1(object sender, EventArgs args)
        {
            // Launch Emergency App
            Navigation.PushAsync(new Views.FTraveller1());
        }
    }
}
