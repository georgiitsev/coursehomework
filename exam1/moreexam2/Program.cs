using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreexam2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter word with 8 letters.");
            string a = Console.ReadLine();

            Console.Write("the fifth letter in this word is : ");
            Console.WriteLine( a [4]);
        }
    }
}
