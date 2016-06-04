using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FloodPing.Views
{
	public partial class Alert4 : ContentPage
	{
		public Alert4 ()
		{
			this.BackgroundImage = "Ipswich.jpg";
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

