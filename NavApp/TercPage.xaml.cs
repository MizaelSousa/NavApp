using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavApp
{
    public partial class TercPage : ContentPage
    {
        void ProximaPage(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new QuartPage());
        }

        void Voltar(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        public TercPage()
        {
            InitializeComponent();
        }
    }
}
