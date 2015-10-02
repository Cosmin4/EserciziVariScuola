using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero = "";
            int n = 0;
            int somma = 0;
            var myReader = new StreamReader("Valori.txt");

            List<string> ContaNumeri = new List<string>();

            while (numero != null)
            {
                numero = myReader.ReadLine();
                try
                {
                    n = Convert.ToInt32(numero);
                    ContaNumeri.Add(numero);

                    somma += n;
                }
                catch (Exception) { }


                Console.WriteLine(numero);
            }

            myReader.Close();
            Console.WriteLine("Somma : " + somma);
            Console.WriteLine("Count: {0}", ContaNumeri.Count);
            Console.ReadKey();
        }
    }
}
