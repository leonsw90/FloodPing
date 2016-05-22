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
    public class EmergencySendMessageFormViewModel : ViewModelBase
    {
        private int noStrandedTravellers = 4;
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
            ToBeSent = "Message sent to all users : " + SendMessageText;
        }

    }
}
