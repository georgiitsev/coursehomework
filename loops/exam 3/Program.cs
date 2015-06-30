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
            int num = 1;

            do
            {
                num++;

                if (num % 7 == 0 || num % 11 == 0)
                {
                    Console.WriteLine(num);
                   continue;
                }
                
                


            } while ( num < 100);
           
        }
    }
}
