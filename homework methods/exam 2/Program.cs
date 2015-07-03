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
            string sucks = "Greetings,";
            Console.WriteLine("PLease enter your name");
            string name = Console.ReadLine();
            string result = GetName(sucks, name);

            Console.WriteLine(result + "!");

        }
        public static string GetName(string sucks, string name)
        {
            string greetingName = sucks + name;
            return greetingName;
        }
    }
}
