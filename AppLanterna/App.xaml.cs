using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppLanterna;

namespace AppLanterna
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new View.Lanterna();
            
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
