using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavApp
{
    public partial class QuartPage : ContentPage
    {
        void ProximaPage(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new QuintPage());
        }

        void Voltar(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        public QuartPage()
        {
            InitializeComponent();
        }
    }
}
