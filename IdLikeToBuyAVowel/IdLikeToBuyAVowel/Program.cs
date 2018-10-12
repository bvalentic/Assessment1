using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdLikeToBuyAVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string to count the number of vowels in it: ");
            string vowelString = Console.ReadLine();
            int vowelCount = 0;
            foreach (char letter in vowelString.ToLower())
            {
                if ("aeiou".Contains(letter))
                {
                    vowelCount += 1;
                }
            }
            Console.WriteLine("This string has " + vowelCount + " vowel(s).");
            Console.ReadKey();
        }
    }
}
