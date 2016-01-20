using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1teht4
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int underage;
            int adult;
            int senior;

            Console.WriteLine("Please tell me your age (years)");
            age = int.Parse(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("You are underage");
            }
            else if (age >= 18 && age < 65)
            {
                Console.WriteLine("You are an adult");
            }
            else 
                Console.WriteLine("You are a senior");
        }
    }
}
