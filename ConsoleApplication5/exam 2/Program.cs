using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 0; ;)
            {
                Console.WriteLine("Enter a number");
                int num = int.Parse(Console.ReadLine());

                sum += num;
                if (num == 0)
                {
                    Console.WriteLine("Sum of all number is : " + sum);
                    break;
                   
                }
                
                
            }
        }
    }
}
