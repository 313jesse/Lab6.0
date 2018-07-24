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
Console.WriteLine("Welcome to the Underground Grand Circus Casino!");
            bool play = true;
            while (play)
            {

                while (true)
                {
                    try
                    {
                        
                        Console.WriteLine("How many sides would you like on your dice?");
                        int userHigh = int.Parse(Console.ReadLine());
                        //after testing realized that the "high" is not equal to user high, but 1 less, so I added +1 to fix
                        RandNumber(1, userHigh + 1);
                        RandNumber(1, userHigh + 1);

                        Console.WriteLine("Would you like to roll again? (Y/N): ");
                        string playAgain = Console.ReadLine();


                        if (playAgain == "y" || playAgain == "Y")

                        {
                            play = true;
                        }

                        else if (playAgain == "n" || playAgain == "N")

                        {
                            play = false;
                            Console.WriteLine("Thanks for playing.");
                            break;

                        }
                    }



                    catch (Exception e)
                    { }


                        

                        }
                    }
                    }
        public static void RandNumber(int Low, int High)
        {

            //stolen code from the internet to create more accurate rando num generator
            Random rndNum = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber));

            int rnd = rndNum.Next(Low, High);
            Console.WriteLine("you rolled a " + rnd);
            {
            }
            }

        }
    }  