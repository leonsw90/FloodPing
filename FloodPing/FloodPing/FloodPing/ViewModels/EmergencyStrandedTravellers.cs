using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using FloodPing.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using GalaSoft.MvvmLight.Command;

namespace FloodPing.ViewModels
{
    public class EmergencyStrandedTravellersViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public ICommand navigateCommand { get; private set; }

        public EmergencyStrandedTravellersViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            
        }

       
    }
}
