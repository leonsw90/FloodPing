using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FloodPing.Views
{
	public partial class Alert : ContentPage
	{
		public Alert ()
		{
			this.BackgroundImage = "AlertPhone.png";
			BindingContext = this;

			InitializeComponent ();
			this.Title = "WARNING";
		}

		public void LaunchFloodAlert2(object sender, EventArgs args)
		{
			// Launch Emergency App
			Navigation.PushAsync(new Views.Alert2());
		}
	}
}

