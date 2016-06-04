using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using GalaSoft.MvvmLight.Command;
using FloodPing.Models;
using FloodPing.Data;

namespace FloodPing.ViewModels
{
    public class EmergencyMapViewModel : ViewModelBase
    {
        //init var
        private int _strandedId;
        private string _strandedName;
        private int _strandedLocationLat;
        private int _strandedLocationLong;
        private string _strandedDetail;
        private StrandedTravellers travellerDetail;

        public EmergencyMapViewModel(int strandedId)
        {
            _strandedId = strandedId;//get the detail of the person stranded

            System.Diagnostics.Debug.WriteLine("val: ");
            System.Diagnostics.Debug.WriteLine(strandedId);
            travellerDetail = App.Database.GetTravellerDetail(strandedId);
            
                System.Diagnostics.Debug.WriteLine("traveller name: ");
            System.Diagnostics.Debug.WriteLine(travellerDetail.traveller_name);

        }

        // Get the total number of stranded travellers.
        private int noStrandedTravellers = App.Database.StrandedTravellerCount();
        private INavigationService _navigationService;
        public ICommand SendMessageCommand { get; private set; }



        
        // Method that sets and gets the number of stranded travellers.
        private int _StrandedTravellers;
        public int StrandedTravellers
        {
            get
            {
                return noStrandedTravellers;
            }
            set
            {
                _StrandedTravellers = value;
                RaisePropertyChanged(() => StrandedTravellers);
            }

        }

        // Method that sets and gets the number of stranded travellers.
        public string strandedName
        {
            get
            {
                return travellerDetail.traveller_name;
            }
            set
            {
                _strandedName = value;
                RaisePropertyChanged(() => strandedName);
            }

        }

        public int strandedLocationLat
        {
            get
            {
                return travellerDetail.stranded_lat;
            }
            set
            {
                _strandedLocationLat = value;
                RaisePropertyChanged(() => strandedName);
            }

        }
        public int strandedLocationLong
        {
            get
            {
                return travellerDetail.stranded_long;
            }
            set
            {
                _strandedLocationLong = value;
                RaisePropertyChanged(() => strandedName);
            }

        }

        public string strandedDetail
        {
            get
            {
                return travellerDetail.emergency_detail;
            }
            set
            {
                _strandedDetail = value;
                RaisePropertyChanged(() => strandedName);
            }

        }

        // Method that sets and get Sending of the text message.
        private string _SendMessageText;
        public string SendMessageText
        {
            get
            {
                return _SendMessageText;
            }
            set
            {
                _SendMessageText = value;
                RaisePropertyChanged(() => SendMessageText);
            }
        }

        // Method that saves the message into the database.
        // Displays a message on the app.
        // Returns to the Stranded Travellers page.
        public void SetSendMessage()
        {
            EmergencyMessages _message = new EmergencyMessages();
            _message.message = SendMessageText;
            _message.message_sentdate = DateTime.Now;
            _message.messageType = "Broadcast";
            App.Database.EmergencyMessageSaveItem(_message);

            MessagingCenter.Send(this, "BroadcastMessageSent", "The broadcase message has been sent to all the stranded travellers.");
            _navigationService.GoBack();

        }



    }
}
