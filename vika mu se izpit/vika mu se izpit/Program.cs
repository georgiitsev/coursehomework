using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vika_mu_se_izpit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of matrix from 2 to 9 : ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int sum = 0;


            int[,] matrix = new int[n, n];
            int[] array = new int[n * n];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine("Enter number ");
                    matrix[i, j] = int.Parse(Console.ReadLine());

                    sum += matrix[i, j];


                }

            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    array[count++] = matrix[j, i];
                }
            }

            Console.WriteLine("Sum of all value in array is {0}", sum);
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }


        }
    }
}
