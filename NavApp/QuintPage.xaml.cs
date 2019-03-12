using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavApp
{
    public partial class QuintPage : ContentPage
    {

        void Voltar(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        public QuintPage()
        {
            InitializeComponent();
        }
    }
}
