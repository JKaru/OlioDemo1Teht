using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1teht14
{
    class Program
    {
        static void Main(string[] args)
        {
            int zero = 0;
            int one = 0;
            int two = 0;
            int three = 0;
            int four = 0;
            int five = 0;
            int numbers = 0;

            do
            {
                Console.WriteLine("Give me your score (Press 6 if you want to end the program)");
                numbers = int.Parse(Console.ReadLine());

                if (numbers == 0)
                    zero++;
                else if (numbers == 1)
                    one++;
                else if (numbers == 2)
                    two++;
                else if (numbers == 3)
                    three++;
                else if (numbers == 4)
                    four++;
                else if (numbers == 5)
                    five++;
                else if (numbers == 6)
                    Console.WriteLine("End");
                else
                    Console.WriteLine("Error 404 score not found");
            } while (numbers != 6);

            Console.WriteLine("");
            Console.Write("0: ");
            for (int i = 0; i < zero; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine("");
            Console.Write("1: ");
            for (int i = 0; i < one; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine("");
            Console.Write("2: ");
            for (int i = 0; i < two; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine("");
            Console.Write("3: ");
            for (int i = 0; i < three; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine("");
            Console.Write("4: ");
            for (int i = 0; i < four; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine("");
            Console.Write("5: ");
            for (int i = 0; i < five; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
