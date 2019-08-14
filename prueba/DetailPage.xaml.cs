using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace prueba
{
    public partial class DetailPage : ContentPage
    {
        async void OnButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
            
        }

        public DetailPage()
        {
            InitializeComponent();

            //BindingContext = this;
        }
    }
}
