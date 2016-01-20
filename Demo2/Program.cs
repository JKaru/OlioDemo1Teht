using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarjoituksetDemot1
{
    class Program
    {
        static void Main(string[] args)
        {
            int points;

                Console.WriteLine("Please enter the amount of points.");
                points = int.Parse(Console.ReadLine());

                if (points >= 0 && points <= 1)
                {
                    Console.WriteLine("Grade is 0");
                }
                else if (points >= 2 && points <= 3)
                {
                    Console.WriteLine("Grade is 1");
                }
                else if (points >= 4 && points <= 5)
                {
                    Console.WriteLine("Grade is 2");
                }
                else if (points >= 6 && points <= 7)
                {
                    Console.WriteLine("Grade is 3");
                }
                else if (points >= 8 && points <= 9)
                {
                    Console.WriteLine("Grade is 4");
                }
                else if (points >= 10 && points <= 12)
                {
                    Console.WriteLine("Grade is 5");
                }
                
        }
    }
}
