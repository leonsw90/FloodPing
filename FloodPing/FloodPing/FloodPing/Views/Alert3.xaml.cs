using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FloodPing.Views
{
	public partial class Alert3 : ContentPage
	{
		public Alert3 ()
		{
			this.BackgroundImage = "flood1.png";
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

