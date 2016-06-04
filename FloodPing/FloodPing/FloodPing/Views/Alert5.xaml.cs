using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FloodPing.Views
{
	public partial class Alert5 : ContentPage
	{
		public Alert5 ()
		{
			this.BackgroundImage = "Oxley.jpg";
			BindingContext = this;

			InitializeComponent ();
			this.Title = "WARNING";

		}
		public void LaunchFloodAlert3(object sender, EventArgs args)
		{
			// Launch Emergency App
			Navigation.PushAsync(new Views.MainPage());
		}
	}
}

