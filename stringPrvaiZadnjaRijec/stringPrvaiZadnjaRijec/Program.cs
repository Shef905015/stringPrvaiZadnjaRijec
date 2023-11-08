using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringPrvaiZadnjaRijec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recenica;

            Console.Write("Unesite neku recenicu: ");
            recenica = Console.ReadLine();

            Console.WriteLine("Ovo je prva rijec: " + recenica.Substring(0, recenica.IndexOf(" ")));
            Console.WriteLine("Ovo je zadnja rijec: " + recenica.Substring(recenica.LastIndexOf(" ") + 1));

            Console.ReadKey();
        }
    }
}
