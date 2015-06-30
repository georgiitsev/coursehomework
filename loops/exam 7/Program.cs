using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_7
{
    class Program
    {
        static void Main(string[] args)
        {//ПОНЕЖЕ СЪМ ЧЕСТЕН С ВАС ЗА ТАЗИ ЗАДАЧА ПОЛЗВАХ ПОМОЩ ОТ ПРИЯТЕЛ!!!!!!
            string[] numbers;
            bool isInteger = true;
            int min = int.MaxValue;
            int max = int.MinValue;
            Console.WriteLine("Enter a number split with   \".\":");
            numbers = (Console.ReadLine()).Split('.');
            int[] intNumbers = new int[numbers.Length];
            for (int i = 0; i < numbers.Length ; i++)
            {
                isInteger = int.TryParse(numbers[i], out intNumbers[i]);
                if (isInteger == false)
                {
                    break;
                }
            }
            if (isInteger)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (intNumbers[i] < min)
                    {
                        min = intNumbers[i];
                    }
                    if (intNumbers[i] > max)
                    {
                        max = intNumbers[i];
                    }
                }
                Console.WriteLine("minimal={0}", min);
                Console.WriteLine("maximal={0}", max);
            }
            else
            {
                Console.WriteLine("Not a valid entry try again!");
            }
        }
    }
}


