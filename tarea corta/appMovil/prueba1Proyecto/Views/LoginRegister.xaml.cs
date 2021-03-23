using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prueba1Proyecto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginRegister : ContentPage
    {
        public LoginRegister()
        {
            InitializeComponent();
            buttonLogin.Clicked += (sender, e) =>
            {
                Navigation.PushModalAsync(new Views.Login());
            };

            buttonRegister.Clicked += (sender, e) =>
            {
                Navigation.PushModalAsync(new Views.Register());
            };
        }


  
    }
}