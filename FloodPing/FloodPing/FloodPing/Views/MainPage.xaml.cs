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
        }

        public void LaunchEmergencySendMassMessage(object sender, EventArgs args)
        {
            // Launch Emergency App
            Navigation.PushAsync(new Views.EmergencySendMassMessage());
        }
    }
}
