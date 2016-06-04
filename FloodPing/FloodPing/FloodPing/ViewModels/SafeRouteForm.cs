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
    class SafeRouteViewModel : ViewModelBase
    {
        // Get the total number of stranded travellers.
        private int noSafeRoutes = App.Database.SafeRoutesCount();
        private INavigationService _navigationService;
        public ICommand SendMessageCommand { get; private set; }

        public SafeRouteViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            // Set the method that handles sending of the messages.
            SendMessageCommand = new Command(() => SetSendMessage());
        }


        // Method that sets and gets the number of SafeRoutes.


        // Method that sets and get Sending of the text message.



        private string _SaveRoute;
        public string SaveRouteText
        {
            get
            {
                return _SaveRoute;
            }
            set
            {
                _SaveRoute = value;
                RaisePropertyChanged(() => SaveRouteText);
            }
        }

        // Method that saves the message into the database.
        // Displays a message on the app.
        // Returns to the Stranded Travellers page.
        public void SetSendMessage()
        {
            SafeRoutes _routelocation = new SafeRoutes();
            _routelocation.LocationName = SaveRouteText;
            _routelocation.CreatedOn = DateTime.Now;
            App.Database.SafeRoutesitemsave(_routelocation);
                

            MessagingCenter.Send(this, "Destination Saved", "This Route Dentination has been saved. You can see the list from the upper right corner.");
           // _navigationService.GoBack();


        }




    }
}
