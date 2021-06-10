using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SoundPocket.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new DiscoverPage());
        }
    }
}
