using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_exam
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Print();
        }
        public static void Print()
        {
         
                     

            for ( int i  = 10; i <= 999 ; i++)
            {
                if (i > 100 )
                {
                    int number1 = i / 100;
                    int number2 = i % 10;

                    if (number1 == number2)
                    {
                        Console.WriteLine(i);

                    }
                }
              

                if (i < 100)
                {
                    if ((i % 11 == 0))
                    {
                        Console.WriteLine(i);
                    }

                   
                    
                }
               
            }
        }
    }
}
