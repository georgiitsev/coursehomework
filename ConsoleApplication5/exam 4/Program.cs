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
            int number = 1;

            while (number <= 99)
                
            {
                number++;
                
                if (number % 7 == 0 || number % 11 == 0)
                {

                    Console.WriteLine(number);
                    continue;
                    
                }  
              
            }

        }
    }
}
