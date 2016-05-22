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
            BindingContext = new EmergencySendMessageFormViewModel(SimpleIoc.Default.GetInstance<INavigationService>());
        }

        public void ClickSendMessage(object sender, EventArgs e)
        {
            
        }
    }
}
