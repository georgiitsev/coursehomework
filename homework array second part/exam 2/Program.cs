using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 4];
            int count = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {


                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine("Enter number " + count++);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            foreach (int elements in matrix)
            {
                
                Console.Write(elements  + " , ");
            }
        }
    }
}
