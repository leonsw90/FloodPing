﻿using FloodPing.Implementations;
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
    public partial class EmergencyMap : ContentPage
    {
        public EmergencyMap()
        {
            Button button1 = new Button { };
            button1.StyleId = "text";
            InitializeComponent();

            // Dynamically generate dots on the map.
            // This is a proof of concept.
            // The real application would get GPS location from the straded travellers.
            // And use Google maps API's to draw the map on screen.

            // Create a grod.
            var grid = new Grid
            {
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
            var TravellerDetail = App.Database.GetStrandedTravellers();

            // Loop through the list of travellers and create
            // dots on the map.
            foreach (var t in TravellerDetail)
            {
                Button b = new Button
                {
                    StyleId = (t.ID).ToString(),
                    Image = "spot.png",
                    BorderWidth = 5,
                    BackgroundColor = Color.Red,
                    AnchorX = 0,
                    AnchorY = 0,
                    TranslationY = t.stranded_long,
                    TranslationX = t.stranded_lat,
                    WidthRequest = 5,
                    HeightRequest = 5,
                    Scale = 3,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center

                    //HorizontalOptions = LayoutOptions.FillAndExpand
                };
                b.Clicked += OnButtonClicked;
                
                grid.Children.Add(b, t.stranded_long, t.stranded_lat);

            }

            // Render the buttons on screen.
            content.Children.Add(grid);
            this.Content = content;

        }


        void OnButtonClicked(object sender, EventArgs e)
        {
            string id = ((Button)sender).StyleId;
            int travellerID = Int32.Parse(id);
            Navigation.PushAsync(new MapDetail(travellerID));
        }
    }
}