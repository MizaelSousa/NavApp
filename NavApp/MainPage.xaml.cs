using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavApp
{
    public partial class MainPage : ContentPage
    {
        void ProximaPage(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SegPage());
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
