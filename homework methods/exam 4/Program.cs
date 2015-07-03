using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_4
{
    class Program
    {
        static void Main(string[] args)
        {
            EvenOrOdd();
           
        }

        public static void EvenOrOdd()
        {
            Console.WriteLine("Enter random number : ");
            int random = int.Parse(Console.ReadLine());

            if (random % 2 == 0)
            {
                Console.WriteLine("The number  {0} is even! ",random);
            }
            else
            {
                Console.WriteLine("The number  {0} is odd! ",random);
            }
        }
    }
}
