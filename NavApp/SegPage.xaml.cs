using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavApp
{
    public partial class SegPage : ContentPage
    {
        void ProximaPage(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new TercPage());
        }

        void Voltar(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        public SegPage()
        {
            InitializeComponent();
        }
    }
}
