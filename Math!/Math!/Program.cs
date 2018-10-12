using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number to find its multiplication table: ");
            double times = double.Parse(Console.ReadLine());
            int count = 0;
            while (count < 13)
            {
                Console.WriteLine($"{times,-2} x {count,-2} = {count*times}");
                count += 1;
            }
            Console.ReadKey();
        }
    }
}
