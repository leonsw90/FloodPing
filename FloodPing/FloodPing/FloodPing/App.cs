using FloodPing.Implementations;
using FloodPing.Views;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FloodPing
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            //MainPage = new Views.MainPage();
            var nav = new NavigationService();
            nav.Configure(Locator.MainPage, typeof(MainPage));
            nav.Configure(Locator.SecondPage, typeof(EmergencySendMassMessage));
            nav.Configure(Locator.ThirdPage, typeof(EmergencySendMessageForm));
            nav.Configure(Locator.FouthPage, typeof(FTravellerMain));

            nav.Configure(Locator.FifthPage, typeof(FTraveller1));
            nav.Configure(Locator.SixthPage, typeof(FTraveller2));
            nav.Configure(Locator.SevenPage, typeof(FTraveller3));
            nav.Configure(Locator.EightPage, typeof(FTraveller4));
            nav.Configure(Locator.NinthPage, typeof(ShowStatistics));
            nav.Configure(Locator.TenthPage, typeof(SharePics));

            nav.Configure(Locator.TenthPage, typeof(GraphShowing));
            nav.Configure(Locator.EmergencyMapPage, typeof(EmergencyMap));





            SimpleIoc.Default.Register<INavigationService>(() => nav);
            var mainPage = new NavigationPage(new MainPage());
            nav.Initialize(mainPage);
            MainPage = mainPage;
            //MainPage = new NavigationPage(new Views.MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
