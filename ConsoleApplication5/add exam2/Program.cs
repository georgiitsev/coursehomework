using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_exam2
{
    class Program
    {
        static void Main(string[] args)
        {//В случай че трябва да не се въвеждат от конзолата съм ги закоментирал ако пък ли не опитай с CTR+E,U
            Console.WriteLine("Enter a number N : ");
            int numN = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number K :");
            int numK = int.Parse(Console.ReadLine());
            //int N = 6;
            //int K = 7;
            long factorialN = 1;
            long factorialM = 1;

            for (int i = 0; i < numN; i++)
            {
                factorialN *= numN;
            }
            for (int i = 0; i < numK; i++)
            {
                factorialM *= numK;
            }
          // long multiply = factorialM * factorialN;    //този ред може да се използва 
            //long partiotion = factorialN - factorialM;  // този ред може да се използва
            Console.WriteLine((factorialN*factorialM) /(factorialN-factorialM));
           // Console.WriteLine(multiply / partition);
        }
    }
}
