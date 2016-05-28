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

namespace FloodPing.ViewModels
{
    public class EmergencySendMessageFormViewModel : ViewModelBase
    {
        private int noStrandedTravellers = App.Database.StrandedTravellerCount();
        private INavigationService _navigationService;
        
        public EmergencySendMessageFormViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            SendMessageCommand = new Command(() => SetSendMessage());
            
            
        }

        private int _StrandedTravellers;
        public int StrandedTravellers
        {
            get {
                return noStrandedTravellers;
            }
            set
            {
                _StrandedTravellers = value;
                RaisePropertyChanged(() => StrandedTravellers);
            }

        }

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

        private string _ToBeSent;
        public string ToBeSent
        {
            get
            {
                return _ToBeSent;
            }
            set
            {
                _ToBeSent = value;
                RaisePropertyChanged(() => ToBeSent);
            }
        }
        

        public ICommand SendMessageCommand { get; private set; }

        public void SetSendMessage()
        {
            //ToBeSent = "Message sent to all users : " + SendMessageText;

            EmergencyMessages _message = new EmergencyMessages();
            _message.message = SendMessageText;
            _message.message_sentdate = DateTime.Now;
            _message.messageType = "Broadcast";
            App.Database.EmergencySaveItem(_message);

            MessagingCenter.Send(this, "BroadcastMessageSent", "The broadcase message has been sent to all the stranded travellers.");
            _navigationService.NavigateTo(Locator.EmergencySendMassMessagePage);

        }



    }
}
