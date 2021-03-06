﻿using GalaSoft.MvvmLight;
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
    // ViewModel for handling the Emergency Messages
    public class EmergencySendMessageFormViewModel : ViewModelBase
    {
        // Get the total number of stranded travellers.
        private int noStrandedTravellers = App.Database.StrandedTravellerCount();
        private INavigationService _navigationService;
        public ICommand SendMessageCommand { get; private set; }

        public EmergencySendMessageFormViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            // Set the method that handles sending of the messages.
            SendMessageCommand = new Command(() => SetSendMessage()); 
        }

        // Method that sets and gets the number of stranded travellers.
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
            _message.eventID = 1;
            _message.message = SendMessageText;
            _message.message_sentdate = DateTime.Now;
            _message.messageType = "Broadcast";
            App.Database.EmergencyMessageSaveItem(_message);

            MessagingCenter.Send(this, "BroadcastMessageSent", "The broadcase message has been sent to all the stranded travellers.");
            _navigationService.GoBack();

        }



    }
}
