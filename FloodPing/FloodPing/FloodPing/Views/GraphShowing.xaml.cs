using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FloodPing.Views
{
    public partial class GraphShowing : ContentPage
    {
        public GraphShowing()
        {
            this.BackgroundImage = "graph1.JPG";
            BindingContext = this;

            InitializeComponent();
        }
    }
}
