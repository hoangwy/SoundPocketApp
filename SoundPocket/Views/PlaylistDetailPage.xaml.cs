using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SoundPocket.Views
{
    public partial class PlaylistDetailPage : ContentPage
    {
        public PlaylistDetailPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        void BtnPlaySong_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
