using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_3
{
    class Program
    {
        
        static void Main(string[] args)
        {


            for (int i = 1; i <= 10 ; i++)
            {
                Console.WriteLine("Enter a : " + i);
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter b : " + i);
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter c : " + i);
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine(Print(a,b,c));
            }
        }

       public static int Print(int a, int b, int c)
        {
          int result =  a * b * c;
          return result;
        }
    }
}
