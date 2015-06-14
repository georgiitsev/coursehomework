using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreexam1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the word :");
            string letter1 = Console.ReadLine();

            Console.WriteLine("enter the second word :");
            string letter2 = Console.ReadLine();

            Console.Write(" Letter 2  conteince in the letter 1 ? ");
            Console.WriteLine(letter1.Contains(letter2));
        }
    }
}
