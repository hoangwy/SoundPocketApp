using System;
using System.Collections.Generic;
using SoundPocket.ViewModels;
using Xamarin.Forms;

namespace SoundPocket.Views
{
    public partial class DiscoverPage : ContentPage
    {
        private DiscoverViewModel viewModel;

        public DiscoverPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            this.BindingContext = viewModel = new DiscoverViewModel();
        }
    }
}
