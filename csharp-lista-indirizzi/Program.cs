using csharp_lista_indirizzi.Classes;
using csharp_lista_indirizzi.Helper;

namespace csharp_lista_indirizzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Antonio\source\repos\csharp-lista-indirizzi\csharp-lista-indirizzi\data\my-addresses.csv";
            StreamReader file = File.OpenText(path);
            List<Address> addresses = new List<Address>();

            {

                int iteration = 0; 

                while (!file.EndOfStream)
                {
                
                string line = file.ReadLine();
                
                if (iteration > 0)
                    {
                        try
                        {
                            Address address = AddressHelper.CreateAddressFromCVS(line.Split(','));
                            addresses.Add(address);
                        }
                        catch (Exception ex){ Console.WriteLine(ex.Message);  }
                    }
                    iteration++;
                }
                file.Close();
            }


            foreach (var item in addresses)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
        }


        //FUNCTION
        static void SplitLine(string line) {

            string[] splitedLine = line.Split(",");

            for (int i = 0; i < splitedLine.Length; i++)
            {
                Console.WriteLine(splitedLine[i]);
            }

        }

        
    }
}