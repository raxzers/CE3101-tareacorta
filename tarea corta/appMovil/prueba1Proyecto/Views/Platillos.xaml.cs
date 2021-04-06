using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prueba1Proyecto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Platillos : ContentPage
    {
        public Platillos()
        {
            InitializeComponent();
            

        }

        private async void LlenarPlatillos()
        {
            HttpClient cliente = new HttpClient();
            
        }
    }
}