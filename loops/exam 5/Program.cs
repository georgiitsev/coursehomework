using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 1; i <= n ; i++)
            {
                Console.WriteLine("Number : " + i);
            }
        }
    }
}
