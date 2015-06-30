using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_3_index_multiplied_by_10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 10;
                Console.WriteLine(array[i]);
            }

           
        }
    }
}
