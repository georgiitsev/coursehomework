using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_6
{
    class Program
    {
        static void Main(string[] args)
        {
                   Console.WriteLine("Enter a number: ");
         int n = int.Parse(Console.ReadLine());
         Console.WriteLine("");

         for (int i = 1; i <= n; i++)
         {
             if (i % 3 != 0 && i % 7 != 0)
             {
                 Console.WriteLine(i);

                 continue;
             }
             



         }
          /*     
            Console.WriteLine("Enter a number: ");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 1; i <= s; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.WriteLine(i);
                    continue;

                }
                
            */


            }

        }
    }

//5}