using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1teht17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] table1 = new int[5] { 10, 20, 30, 40, 50 };
            int[] table2 = new int[5] { 5, 15, 25, 35, 45 };
            int[] table3 = table1.Concat(table2).ToArray();

            Console.Write("The first table is: ");
            for (int i = 0; i < table1.Length; i++)
            {
                Console.Write(table1[i]);
                Console.Write(",");
            }
            Console.WriteLine("");
            Console.Write("The second table is: ");
            for (int i = 0; i < table2.Length; i++)
            {
                Console.Write(table2[i]);
                Console.Write(",");
            }
            Console.WriteLine("");

            Array.Sort(table3);

            Console.Write("The combined table is: ");
            for (int i = 0; i < table3.Length; i++)
            {
                Console.Write(table3[i]);
                Console.Write(",");
            }
            Console.WriteLine();
        }
    }
}
