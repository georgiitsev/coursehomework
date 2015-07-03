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
         
                     

            for ( int i  = 10; i < 999 ; i++)
            {
                

                if ( i % 101 == 0 || i % 111 ==0 )
                {
                    Console.WriteLine(i);
                }
               
                
                if ((i % 11 == 0) && (i < 100))
                {
                    Console.WriteLine(i);//Сега ги качвам но тази ще я дореша не пишете точки още
                }
            }
        }
    }
}
