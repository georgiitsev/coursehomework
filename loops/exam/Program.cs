using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)

        {
           

            for (int sum = 1; sum <= 100; sum++)
            {
                 if ((sum % 7 == 0) || (sum % 11 == 0))
                {
                    Console.WriteLine(sum);
                    continue; 
                }

                
            
            }
               
            
        }
    }
}
