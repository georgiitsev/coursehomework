using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the card: ");
            string card = (Console.ReadLine());
            //I used   ".ToUpper();"   for capitals or Главни букви  
            card = card.ToUpper();

            switch (card)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "J":
                case "10 ":
                case "Q":
                case "K":
                case "A":
                    Console.WriteLine("This is a valid card thanks");
                    break;
                default:
                    Console.WriteLine("This is a invalid card try again");
                    break;
            }

        }
    }
}



