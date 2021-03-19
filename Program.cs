using System;

namespace RandomGuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.Write("Guess a number between 0 and 100: ");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.WriteLine("Oops too high!  Guess lower...");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("Oops too low!  Guess higher...");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("You Got It!!!");
                    win = true;
                }

                Console.WriteLine();
            } while (win == false);

            Console.WriteLine("Thanks for playing!  Wink Wink...");
            Console.WriteLine("Press any key to close:");
            Console.ReadKey(true);
        }
    }
}
