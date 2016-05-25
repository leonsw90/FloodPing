using FloodPing.Implementations;
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
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void LaunchTraveller(object sender, EventArgs args)
        {
            // Launch Traveller App
            Navigation.PushAsync(new Views.FTravellerMain());
        }

        public void LaunchEmergencySendMassMessage(object sender, EventArgs args)
        {
            // Launch Emergency App
            Navigation.PushAsync(new Views.EmergencySendMassMessage());
        }
        public void LaunchStatistics(object sender, EventArgs args)
        {
            // Launch Emergency App
            Navigation.PushAsync(new Views.ShowStatistics());
        }
            public void LaunchShare(object sender, EventArgs args)
        {
            // Launch Emergency App
            Navigation.PushAsync(new Views.SharePics());
        }
        public void LaunchEmergencyMap(object sender, EventArgs args)
        {
            // Launch Emergency App
            Navigation.PushAsync(new EmergencyMap());
        }
    }
    }

