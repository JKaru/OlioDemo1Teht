using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1teht18
{
    class Program
    {
        static bool IsPalindrome(string src)

        {

            bool palindrome = true;

            for (int i = 0; i < src.Length / 2 + 1; i++)

            {

                if (src[i] != src[src.Length - i - 1])

                {

                    palindrome = false;

                    break;

                }

            }

            return palindrome;

        }

        static void Main(string[] args)
        {
            Console.Write("Enter a String: ");

            string s = Console.ReadLine();

            if (IsPalindrome(s) == true)

            {

                Console.WriteLine(s + " is a palindrome");

            }

            else

            {

                Console.WriteLine(s + " is NOT a palindrome");
            }
        }
    }
}
