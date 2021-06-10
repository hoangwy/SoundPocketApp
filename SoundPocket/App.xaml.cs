using System;
using SoundPocket.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SoundPocket
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Sharpnado.Tabs.Initializer.Initialize(false, false);

            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
