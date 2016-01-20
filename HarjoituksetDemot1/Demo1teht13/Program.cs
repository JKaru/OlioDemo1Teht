using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1teht13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] table = new int[5];
            int sum = 0;
            
            for (int i=0; i<table.Length ;i++)
            {
                Console.WriteLine("Give me the points: ");
                table[i] = int.Parse(Console.ReadLine());

                
            }

            Array.Sort(table);
            for(int g=1;g<table.Length-1;g++)
            {
                sum += table[g];
            }

            Console.WriteLine("The score is "+ sum);
        }
    }
}
