using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upgrate_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some card ");
            string card = Console.ReadLine();
            string cards = "2,3,4,5,6,7,8,9,10,J,Q,K,A";
            card = card.ToUpper();

            if (cards.Contains(card))
            {
                Console.WriteLine("THIS IS A VALID CARD THANKS!");

            }
            else
            {
                Console.WriteLine("THIS IS INVALID CARD SORRY!!!");
            }

        }
    }
}

