using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_array_second_part
{
    class Program
    {
        static void Main(string[] args)
        {

          

            int[,] matrix = new int[2, 3]{
            {1,2,3},
            {4,5,6},
            
            };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] % 2 == 0)
                    {
                        Console.WriteLine(matrix[i,j]);


                    }


                }
              
            }
            
        }
    }
}
          

                



