using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BondJames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first and last name: ");
            string originalName = Console.ReadLine();
            string[] splitName = originalName.Split(' ');

            string bondName = splitName[1] + " " + splitName[0];
            Console.WriteLine(bondName);
            Console.ReadKey();
        }
    }
}
