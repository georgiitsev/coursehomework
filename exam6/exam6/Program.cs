using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter decimal number");

            string num = Console.ReadLine();

            double a = double.Parse(num);

            int x = 2;
            
            Console.WriteLine(a / x );
        }
    }
}
