using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 0;
            int number2 = 0;
            int number3 = 0;
            int add;
            int average;

            Console.WriteLine("Please type in a number");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please type in the second number");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please type in the third number");
            number3 = int.Parse(Console.ReadLine());

            add = number1 + number2 + number3;
            average = (number1 + number2 + number3) / 3;

            Console.WriteLine("The Sum is " +add);
            Console.WriteLine("The average is " + average);    

        }
    }
}
