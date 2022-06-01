using System;
using University.App.Views.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace University.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginView());
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
