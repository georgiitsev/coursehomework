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
            Console.WriteLine("Master your lucky number is 20 !!!!!!!!!!!!!!!!!! \n Please enter a number : ");///Майтап да става 
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];
            int count = 1;
            

            Console.WriteLine("Enter  number " );
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {


                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine("Enter number " + count++);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        Console.Write("The even numbers in matrix are : ");
                        Console.WriteLine(matrix[i, j] );

                    }
                    else
                    {
                        break;
                        Console.WriteLine("there are no even numbers");
                       
                    }


                }

            }

        }
    }
}