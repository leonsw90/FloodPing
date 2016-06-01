using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FloodPing.Views
{
    public partial class EmergencyViewMessageHistory : ContentPage
    {
        private ListView _messages;

        public EmergencyViewMessageHistory()
        {
            InitializeComponent();

            var messages = App.Database.GetEmergencyMessages();
            _messages = new ListView();
            _messages.ItemsSource = messages;
            _messages.ItemTemplate = new DataTemplate(typeof(TextCell));
            _messages.ItemTemplate.SetBinding(TextCell.TextProperty, "message_sentdate");
            _messages.ItemTemplate.SetBinding(TextCell.DetailProperty, "message");

            Content = _messages;
        }

        public void Refresh()
        {
            _messages.ItemsSource = App.Database.GetEmergencyMessages();
        }
    }
}
