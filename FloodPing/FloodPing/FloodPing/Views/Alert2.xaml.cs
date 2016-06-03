using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FloodPing.Views
{
	public partial class Alert2 : ContentPage
	{
		public Alert2()
		{
			this.BackgroundImage = "floodplace.png";
			BindingContext = this;

			InitializeComponent ();
			this.Title = "WARNING";
		}

		public void LaunchFloodAlert3(object sender, EventArgs args)
		{
			// Launch Emergency App
			Navigation.PushAsync(new Views.Alert3());
		}
	}
}

