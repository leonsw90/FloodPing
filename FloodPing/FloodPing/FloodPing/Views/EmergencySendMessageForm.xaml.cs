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
    public partial class EmergencySendMessageForm : ContentPage
    {
        public EmergencySendMessageForm()
        {
            InitializeComponent();
            // Bind the view to the ViewModel
            BindingContext = new EmergencySendMessageFormViewModel(SimpleIoc.Default.GetInstance<INavigationService>());
            
            // Setup messaging centre to handle message from the viewModel.
            MessagingCenter.Subscribe<EmergencySendMessageFormViewModel, string>(this, "BroadcastMessageSent", (sender, arg) => {
                DisplayAlert("Broadcast Message Sent", arg, "OK");
            });
            
        }


    }
}
