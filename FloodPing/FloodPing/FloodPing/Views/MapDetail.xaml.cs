using FloodPing.Implementations;
using FloodPing.ViewModels;
using GalaSoft.MvvmLight;
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
    public partial class MapDetail : ContentPage
    {
        public MapDetail()
        {
            InitializeComponent();

            // Bind the view to the ViewModel
            BindingContext = new EmergencyMapViewModel(1);


        }
        public void LaunchEmergencyMap(object sender, EventArgs args)
        {
            // Launch Emergency App
            Navigation.PushAsync(new EmergencyMap());
        }
    }
}
