using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_methods
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine();
            Console.WriteLine("Enter number a : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number c : ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //MaxNumber(5,255);
            MaxNumber(a,b,c);

        }
        //public static void MaxNumber(int a, int b)
        //{
        //    int max = 0;
        //    if (a > b)
        //    {
        //        max = a;
        //        Console.WriteLine("The bigger number is a = {0}", a);
        //    }
        //    else
        //    {
        //        max = b;
        //        Console.WriteLine("The bigger number is b = {0}", b);
        //    }
       // }

        public static void MaxNumber(int a, int b,int c )
        {
           
            int max = 0;
            if (a > b && b > c)
            {

                max = a;
                Console.WriteLine("The bigger number is a = {0}",a);
            }
            else if (b > a && a > c)
            {
                max = b;
                Console.WriteLine("The bigger number is b = {0}", b);
            }
            else
            {
                max = c;
                Console.WriteLine("The bigger number is c = {0}", c);
            }
            
               
        }
    }
}
