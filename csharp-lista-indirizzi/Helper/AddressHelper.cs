using csharp_lista_indirizzi.Classes;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi.Helper
{
    public static class AddressHelper
    {
        public static Address CreateAddressFromCVS(string[] array)
        {

           
            Address address = new Address();
            address.Name = RemoveNullString(array[0]);
            address.Surname = RemoveNullString(array[1]);
            address.Street = RemoveNullString("");
            address.City = RemoveNullString("");
            address.Province = RemoveNullString(array[array.Length - 2]);
            address.ZIPCode = RemoveNullString(array[array.Length - 1]);

            if (array.Length >= 6)
            {
                address.Street = RemoveNullString(array[array.Length - 4]);
                address.City = RemoveNullString(array[array.Length - 3]);
            }

            return address;
        }
            
        private static string RemoveNullOrEmptyString(string _string)
        {
            if(string.IsNullOrEmpty(_string))
                return "Nessun Dato";
            return _string;
        }
    }
}
