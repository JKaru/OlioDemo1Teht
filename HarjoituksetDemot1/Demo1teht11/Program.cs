using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1teht11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number");
            int number;
            number = int.Parse(Console.ReadLine());
            for (int i=0; i<number; i++)
            {
                for (int j = 0; j<=i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
