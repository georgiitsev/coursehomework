using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_print_the_hell_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 30; i > 0; i--)
            {
                Console.Write("{0}   \t", i);
                if ((i - 1) % 6 == 0) Console.WriteLine();//Даже разбрах как се попълва матрицата вертикално и спираловидно 
                //играеме с дължината и индексите  с няколко цикъла
            }



        }
    }
}

