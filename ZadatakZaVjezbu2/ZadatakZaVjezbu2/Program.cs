using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakZaVjezbu2
{
    internal class Program
    {

        class KlasaB
        {
            public string BezPrvogIZadnjeg(string prviIZadnji)
            {
                prviIZadnji = prviIZadnji.Remove(prviIZadnji.Length - 1, 1);

                prviIZadnji = prviIZadnji.Remove(0, 1);

                return prviIZadnji;
            }
        }

        static void Main(string[] args)
        {

            KlasaB klasaB = new KlasaB();

            Console.WriteLine("Unesi niz znakova: ");
            string a = Console.ReadLine();

            if(a.Length > 2)
            {
                Console.WriteLine(klasaB.BezPrvogIZadnjeg(a));

            }
            else
            {
                Console.WriteLine("Unesite više od dva znaka");
            }




            Console.ReadKey();

        }
    }
}
