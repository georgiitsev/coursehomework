using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first side: ");

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the hieght: ");
            int h = int.Parse(Console.ReadLine());

            int s = (a * h) / 2;
            Console.WriteLine(s);
        }
    }
}
