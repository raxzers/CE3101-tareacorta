using System.Collections.Generic;
using System.Linq;
using webapi_csharp.Modelos;

namespace webapi_csharp.Repositorios
{
    public class RPClientes
    {
        public static List<Cliente> _listaClientes = new List<Cliente>()
        {
            new Cliente() { Id = "1", Name = "Cliente 1" , LastName = "Apellido 1", address1 = "Cartago", address2 = "Cartago", address3 = "Cartago" , Bday = "28/02/1995" , Mail = "CartagitoCampeon@cartago.es" , Password = "xq405010" , Phone = "85412364" },
            new Cliente() { Id = "2", Name = "Cliente 2" , LastName = "Apellido 2", address1 = "Cartago", address2 = "Cartago", address3 = "San Nicolas" , Bday = "28/05/1995" , Mail = "CartagitoCampeon@hostmail.es" , Password = "123456789" , Phone = "88552233"  },
            new Cliente() { Id = "3", Name = "Cliente 3" , LastName = "Apellido 3", address1 = "Cartago", address2 = "Cartago", address3 = "Guadalupe" , Bday = "28/09/1995" , Mail = "CartagitoCampeon@gamil.com" , Password = "Cartago123" , Phone = "85445645"  }
        };

        public IEnumerable<Cliente> ObtenerClientes()
        {
            return _listaClientes;
        }

        public Cliente ObtenerCliente(string id)
        {
            var cliente = _listaClientes.Where(cli => cli.Id == id);

            return cliente.FirstOrDefault();
        }

        public void Agregar(Cliente nuevoCliente)
        {
            _listaClientes.Add(nuevoCliente);
        }
    }
}
