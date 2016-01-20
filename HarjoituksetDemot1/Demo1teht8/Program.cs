using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1teht8
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3;
            Console.WriteLine("Anna 1. luku");
            luku1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna 2. luku");
            luku2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna 3. luku");
            luku3 = int.Parse(Console.ReadLine());

            if (luku1 > luku2)
            {
                if (luku1 > luku3)
                    Console.WriteLine("Suurin luku on " + luku1);
                else if (luku3 > luku1)
                    Console.WriteLine("Suurin luku on " + luku3);
            }
            else if (luku2 > luku3)
            {
                if (luku2 > luku1)
                    Console.WriteLine("Suurin luku on " + luku2);
                else if (luku1 > luku2)
                    Console.WriteLine("Suurin luku on " + luku1);
            }
            else if (luku3 > luku1)
            {
                if (luku3 > luku2)
                    Console.WriteLine("Suurin luku on " + luku3);
            }

        }
    }
}
