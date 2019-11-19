using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace lab13
{
    public partial class paginaItemPersona : ContentPage
    {
        public paginaItemPersona()
        {
            InitializeComponent();
        }

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var todoPersona = (TodoPersona)BindingContext;
            await App.Database.SaveItemAsync(todoPersona);
            await Navigation.PopAsync();
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var todoPersona = (TodoPersona)BindingContext;
            await App.Database.DeleteItemAsync(todoPersona);
            await Navigation.PopAsync();
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
