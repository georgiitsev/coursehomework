using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_2_sum_all_even_number_in_array

{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the lenght of array : ");
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];

            int sum = 0;

            for (int i = 0; i <= array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                   
                }
            } Console.WriteLine(sum);
           

        }
    }
}
