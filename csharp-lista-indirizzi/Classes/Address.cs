using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi.Classes
{
    public class Address
    {

        public string Name { get;  set; }
        public string Surname { get;  set; }
        public string Street { get;  set; }
        public string City { get;  set; }
        public string Province { get;  set; }
        public string ZIPCode { get;  set; }

        public Address() { }


        public override string ToString()
        {
            return $"\n\t-Nome: {this.Name}\n\t-Cognome: {this.Surname}\n\t-Via: {this.Street}\n\t-Citta: {this.City}\n\t-Provincia: {this.Province}\n\t-CAP: {this.ZIPCode}";
        }

    }
}
