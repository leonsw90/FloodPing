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
using FloodPing.Data;


namespace FloodPing.Views
{
    public partial class EmergencyStrandedTravellers : ContentPage
    {
        public EmergencyStrandedTravellers()
        {
            InitializeComponent();

            // Bind the view to the viewModel
            BindingContext = new EmergencyStrandedTravellersViewModel(SimpleIoc.Default.GetInstance<INavigationService>());
            
            // Add the map background image
            this.BackgroundImage = "map.png";
            
            
            // Dynamically generate dots on the map.
            // This is a proof of concept.
            // The real application would get GPS location from the straded travellers.
            // And use Google maps API's to draw the map on screen.

            // Create a grod.
            var grid = new Grid {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                RowSpacing = 10,
                ColumnSpacing = 10,
                Padding = 100,
                RowDefinitions = {
                    new RowDefinition { Height = 70 },
                    new RowDefinition { Height = 70 }
                },
                ColumnDefinitions = {
                    new ColumnDefinition { Width = '*' },
                    new ColumnDefinition { Width = '*' }
                }
            };

            // Define the stackloyout
            var content = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Padding = 20
            };

            // Retriveve the list of stranded travellers.
            var StrandedTravllers = App.Database.GetStrandedTravellers();

            // Loop through the list of travellers and create
            // dots on the map.
            foreach (var t in StrandedTravllers)
            {
                Button b = new Button
                {
                    StyleId = (t.ID).ToString(),
                    Image = "spot.png",
                    BorderWidth = 0,
                    BackgroundColor = Color.Transparent,
                    WidthRequest = 40,
                    HeightRequest = 40,
                    Scale = 3,
                    HorizontalOptions = LayoutOptions.FillAndExpand
                };
                b.Clicked += OnButtonClicked;

                grid.Children.Add( b, t.stranded_long, t.stranded_lat );
                
            }

            // Render the buttons on screen.
            content.Children.Add(grid);
            this.Content = content;
            
        }

        // Method to display alert with the message.
        // The proper applicatio will have a bind to the ModelView to handle the logic.
        void OnButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Send Message to Individual Traveller", "This option will send a message to an individaul stranded traveller. This function has not been implemented because conceputally it will work the same as sending the message to standed travllers.", "OK");
        }
        
        public void BroadcastMessage(object sender, EventArgs args)
        {
            // Launch Emergency Message Form
            Navigation.PushAsync(new Views.EmergencySendMessageForm());
            
        }

        public void ViewBroadcastHistory(object sender, EventArgs args)
        {
            // Launch Emergency Message Form
            Navigation.PushAsync(new Views.EmergencyViewMessageHistory());

        }
        
    }
}
