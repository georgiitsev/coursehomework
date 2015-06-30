using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_4_find_first_number_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[10]{1,11,111,12,8,525,11,36,0,78};
            Console.WriteLine("Please enter some stupid number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == n)
                {
                    Console.WriteLine("Index of number {0} is : {1}  ",n,i);
                    break;
                }
                
             

            }
        }

    }
}
