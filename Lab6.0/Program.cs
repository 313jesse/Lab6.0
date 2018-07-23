using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._0
{
    class Program
    {

        static void Main(string[] args)
        {
            //static int Rando(int sides)
            //{


                int userHigh;
                Random Roll = new Random();
                Console.WriteLine("How many sides would you like on your first die?");
                userHigh = int.Parse(Console.ReadLine());
                int Dice1 = Roll.Next(1, userHigh);
            //}
        

            int userHigh2;
            Random Roll2 = new Random();
            Console.WriteLine("How many sides would you like on your second die?");
            userHigh2 = int.Parse(Console.ReadLine());
            int Dice2 = Roll.Next(1, userHigh2);
            Console.WriteLine($"you rolled a {1} and a {2}", Dice1, Dice2);

        }
    }
}
