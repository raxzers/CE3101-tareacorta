
using Newtonsoft.Json;
using prueba1Proyecto.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prueba1Proyecto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {

        public Register()
        {
            InitializeComponent();
            
        }


        public async void ButtonAgregar(object sender, EventArgs e)
        {
            

            ClienteRegistroElement cliente = new ClienteRegistroElement();
            cliente.Name = EntryUserName.Text;
            cliente.LastName = EntryUserLastName.Text;
            cliente.Id = EntryUserNumber.Text;
            cliente.Bday = EntryUserDate.Text;
            cliente.Mail = EntryUserMail.Text;
            cliente.Password = EntryUserPassword.Text;
            cliente.Phone = EntryUserPhone.Text;
            cliente.Address1 = EntryUserAdress1.Text;
            cliente.Address2 = EntryUserAdress2.Text;
            cliente.Address3 = EntryUserAdress3.Text;

            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            HttpClient clienteHttp = new HttpClient();
            string url = "http://192.168.0.2:5000/api/clientes/agregar";

            var clientJson = JsonConvert.SerializeObject(cliente);
            var resultado = await clienteHttp.PostAsync(url, new StringContent(clientJson, Encoding.UTF8,"application/json"));
            var json = resultado.Content.ReadAsStringAsync().Result;

            await DisplayAlert("Resultado ", json, "Ok");
            _ = Navigation.PushModalAsync(new LoginRegister());

        }
    }
}