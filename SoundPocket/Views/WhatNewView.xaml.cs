using SoundPocket.ViewModels;
using Xamarin.Forms;

namespace SoundPocket.Views
{
    public partial class WhatNewView : ContentView
    {
        private WhatNewViewModel viewModel;

        public WhatNewView()
        {
            InitializeComponent();

            this.BindingContext = viewModel = new WhatNewViewModel(Navigation);
        }
    }
}
