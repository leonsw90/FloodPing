using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FloodPing.Views
{
    public partial class EmergencyMap : ContentPage
    {
        public EmergencyMap()
        {
            Button button1 = new Button { };
            button1.StyleId = "text";
            InitializeComponent();

        }


        void OnButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", ((Button)sender).StyleId, "ok");
        }
    }
}
