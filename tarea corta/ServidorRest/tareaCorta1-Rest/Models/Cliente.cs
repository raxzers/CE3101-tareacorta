using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi_csharp.Modelos
{
    public class Cliente
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string address3 { get; set; }
        public string Phone { get; set; }
        public string Bday { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
    }
}
