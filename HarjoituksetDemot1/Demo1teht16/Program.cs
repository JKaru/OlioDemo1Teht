using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1teht16
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            int randomNumber = new Random().Next(0, 100);

            do
            {
                Console.WriteLine("Try to guess the number between 0-100");
                int number = int.Parse(Console.ReadLine());

                if (number == randomNumber)
                {
                    Console.WriteLine("Correct! You so smart, wow.");
                }
                else if (number < randomNumber)
                {
                    Console.WriteLine("Too small!");
                }
                else if (number > randomNumber)
                {
                    Console.WriteLine("Too big!");
                }
            } while (!done);

            Console.ReadLine();
        }
    }
}
