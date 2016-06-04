using FloodPing.Data;
using FloodPing.Implementations;
using FloodPing.Views;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using SQLite;

namespace FloodPing
{
    public class App : Application
    {
        static FloodPingDatabase database;

        public App()
        {
            // The root page of your application
            //MainPage = new Views.MainPage();
            var nav = new NavigationService();
            nav.Configure(Locator.MainPage, typeof(MainPage));

            // Emergencey Messaging App
            nav.Configure(Locator.EmergencyStrandedTravellersPage, typeof(EmergencyStrandedTravellers));

            nav.Configure(Locator.FouthPage, typeof(FTravellerMain));
            nav.Configure(Locator.FifthPage, typeof(FTraveller1));
            nav.Configure(Locator.SixthPage, typeof(FTraveller2));
            nav.Configure(Locator.SevenPage, typeof(FTraveller3));
            nav.Configure(Locator.EightPage, typeof(FTraveller4));
            nav.Configure(Locator.NinthPage, typeof(ShowStatistics));
            nav.Configure(Locator.TenthPage, typeof(SharePics));
            nav.Configure(Locator.MapDetailPage, typeof(MapDetail));
            nav.Configure(Locator.TenthPage, typeof(GraphShowing));
            nav.Configure(Locator.EmergencyMapPage, typeof(EmergencyMap));
            nav.Configure(Locator.Heavy, typeof(HeavyImage));
            nav.Configure(Locator.Light, typeof(LightImage));
            nav.Configure(Locator.Medium, typeof(MediumImage));
            nav.Configure(Locator.Facebook, typeof(Facebook));

            nav.Configure(Locator.ViewSavedDestinations_var, typeof(ViewSavedDestinations));



            SimpleIoc.Default.Register<INavigationService>(() => nav);
            var mainPage = new NavigationPage(new MainPage());
            nav.Initialize(mainPage);
            MainPage = mainPage;
        }

        // Function to connect to the local database.
        public static FloodPingDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new FloodPingDatabase();
                }
                return database;
            }
        }
        
        protected override void OnStart()
        {
            // Handle when the app starts
        }

        protected override void OnSleep()
        {
            // Handle when the app sleeps
        }

        protected override void OnResume()
        {
            // Handle when the app resumes
        }
    }
}
