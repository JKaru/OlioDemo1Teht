using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1teht6
{
    class Program
    {
        static void Main(string[] args)
        {
            double matka;
            double litra = 7.02;
            double kulutus;
            double kustannus;
            double hinta = 1.595;
            Console.WriteLine("Anna matka ");
            matka = int.Parse(Console.ReadLine());
            kulutus = litra * (matka / 100);
            kustannus = kulutus * hinta;
            Console.WriteLine("Bensaa kuluu " + kulutus + " litraa, kustannus " + kustannus.ToString("#.##") + " euroa.");
            int dist;
        }
    }
}
