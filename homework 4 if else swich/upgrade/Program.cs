using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number from 1 to 9: ");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine(number * 5);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine(number * 10);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(number * 50);
                    break;

                default:
                    Console.WriteLine("Youre drunk ");
                    break;
            }
        }
    }
}
