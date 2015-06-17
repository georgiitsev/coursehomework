using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_with_points
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number from 1 to 9: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <= 3)
            {
                Console.WriteLine(number * 5);
            }

            else if (number >= 4 && number <= 6)
            {
                Console.WriteLine(number * 10);
            }

            else if (number >= 7 && number <= 9)
            {
                Console.WriteLine(number * 50);
            }

            else
            {
                Console.WriteLine("invalid points ");
            }




        }
    }
}
