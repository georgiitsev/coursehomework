using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number N : ");
            int numN = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number K :");
            int numK = int.Parse(Console.ReadLine());
            //int numN = 6;
          //  int numK = 7;
            long factorialN = 1;
            long factorialM= 1;

            for (int i = 0; i < numN ; i++)
            {
                factorialN *= numN;
            }
            for (int i = 0; i < numK; i++)
            {
                factorialM *= numK;
            }
            Console.WriteLine(factorialN/factorialM);
            Console.WriteLine();
        }
    }
}
