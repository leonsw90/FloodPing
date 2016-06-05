using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FloodPing.ViewModels
{
    class ShowingStatistics
    {
        private int noStrandedTravellers = App.Database.StrandedTravellerCount();
        private INavigationService _navigationService;
        public ICommand SendMessageCommand { get; private set; }
    }
}
