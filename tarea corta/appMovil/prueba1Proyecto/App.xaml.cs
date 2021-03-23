using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prueba1Proyecto
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.LoginRegister();

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
