using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1teht9
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int sum = 0;

            do
            {
                Console.WriteLine("Give a number");
                number = int.Parse(Console.ReadLine());

                sum += number;
            } while (number != 0);
            Console.WriteLine("The sum is: " + sum);
        }
    }
}
