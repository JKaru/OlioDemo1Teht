using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1teht7
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Anna vuosi");
            year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                        Console.WriteLine("Vuosi on karkausvuosi.");
                    else
                        Console.WriteLine("Vuosi ei ole karkausvuosi.");
                }
                else
                    Console.WriteLine("Vuosi on karkausvuosi.");
            }
            else
                Console.WriteLine("Vuosi ei ole karkausvuosi.");
        }
    }
}
