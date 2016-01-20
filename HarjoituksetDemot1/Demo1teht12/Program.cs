using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1teht12
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numValues = 5;
            int[] numbers = new int[numValues];

            int index = numbers.Length;
            for (int i=0; i < numbers.Length; i++)
            {
                Console.Write("Please enter a number: ");
                numbers[--index] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Here are your numbers in reverse order");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }


            Console.ReadLine();
        }
    }
}
