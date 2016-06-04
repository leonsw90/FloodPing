using FloodPing.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FloodPing.ViewModels
{
    public class LocationNamesViewModel : ViewModelBase
    {
        // Get the total number of stranded travellers.
        private int noStrandedTravellers = App.Database.StrandedTravellerCount();
        private INavigationService _navigationService;
        public ICommand SendMessageCommand { get; private set; }

        public LocationNamesViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

        }

        
   



    }
}
