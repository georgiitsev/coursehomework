using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace justexam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number a : ");
            int a =int.Parse( Console.ReadLine());
            Console.WriteLine("Enter number b : ");
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i < b; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("In the interval between {0} and {1} even number/s is {2} : ",a,b,i);
                }
            }
        }
    }
}
