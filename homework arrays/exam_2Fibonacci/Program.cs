using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam1Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sum = 2;
            int newNumber;
            int[] Number = { 0, 1 };
            Console.Write("Enter the number N:");
           int N = int.Parse(Console.ReadLine());
          
                for (int i = 0; i < N - 2; i++)
                {
                    newNumber = Number[0] + Number[1];
                    sum = sum + newNumber;
                    Number[0] = Number[1];
                    Number[1] = newNumber;
                }
                Console.WriteLine("sum={0}", sum );
          
        }
    }
}