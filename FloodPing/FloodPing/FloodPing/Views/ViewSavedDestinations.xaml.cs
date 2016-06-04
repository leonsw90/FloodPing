using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FloodPing.Views
{
    public partial class ViewSavedDestinations : ContentPage
    {
        private ListView _messages;

        public ViewSavedDestinations()
        {
            InitializeComponent();


            var messages = App.Database.GetSafeRoutes();
            _messages = new ListView();
            _messages.ItemsSource = messages;
            _messages.ItemTemplate = new DataTemplate(typeof(TextCell));
            _messages.ItemTemplate.SetBinding(TextCell.TextProperty, "LocationName");
            _messages.ItemTemplate.SetBinding(TextCell.DetailProperty, "CreatedOn");
            _messages.RowHeight = 100; // To change the text size

            Content = _messages;
        }

        public void Refresh()
        {
            _messages.ItemsSource = App.Database.GetSafeRoutes();
        }
    }
}
