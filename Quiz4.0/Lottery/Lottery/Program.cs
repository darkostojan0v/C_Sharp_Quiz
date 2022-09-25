using System;

namespace Lottery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If the number you choose matches one of the 7 random numbers, you will double the amount you bet!");

            Console.WriteLine("So please pick a number from 1 to 37.");

            string userInputNumber = Console.ReadLine();

            int userLuckyNumber = Convert.ToInt32(userInputNumber);

            Console.WriteLine("Please enter your stake.");

            string userInputAmount = Console.ReadLine();

            int userBet = Convert.ToInt32(userInputAmount);

            if (userLuckyNumber < 1 || userLuckyNumber > 37)
            {
                Console.WriteLine("The number must be from 1 to 37!");
            }

            if(userBet < 1)
            {
                Console.WriteLine("You can not bet less than 1$!");
            }

            Console.WriteLine("-------- LOTTERY --------");

            int check = 0;

            Random random = new Random();
            int[] Lottery = new int[7];

            for (int i = 0; i < Lottery.Length; i++)
            {
                check = random.Next(1, 37);
                Lottery[i] = check;

                Console.WriteLine(check);

            }

            if (userLuckyNumber == check)
            {
                Console.WriteLine($"Congratulations, you just won {userBet + userBet}$!");
            }
            else
            {
                Console.WriteLine("Better luck next time..");
            }

            Console.ReadLine();
        }
    }
}
