using FloodPing.Models;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FloodPing.ViewModels
{
    class FloodLocationSender
    {
        private int _strandedId;
        private string _PlaceName;
        private string _Location;
        private int _Chance;
        private FloodLocation FloodLocation_obj;



        public FloodLocationSender(int strandedId)
        {
            _strandedId = strandedId;//get the detail of the person stranded

            System.Diagnostics.Debug.WriteLine("val: ");
            System.Diagnostics.Debug.WriteLine(strandedId);
            FloodLocation_obj = App.Database.GetFloodLocations(strandedId);


            System.Diagnostics.Debug.WriteLine("Location Namee: ");
            System.Diagnostics.Debug.WriteLine(FloodLocation_obj.Location);

        }

        // Get the total number Flood Locations.
        private int noFloodLocations = App.Database.StrandedTravellerCount();
        private INavigationService _navigationService;
        public ICommand SendMessageCommand { get; private set; }

        // Method that sets and gets the number of stranded travellers.
        private int _StrandedTravellers;
        public int StrandedTravellers;
       

    }
}
