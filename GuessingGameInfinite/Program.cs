using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Игра "Угадай номер"
            // Программа генерирует случайное число от 1 до 10
            // Программа предлагает пользователю угадать это число
            // Пользователь пытается угадать это число
            // Если пользователь угадал это число, программа поздравляет его с победой
            // Количество попыток угадать число неограничено
            // случайное число генерируется только один раз

            bool loopActive = true;

            Random rnd = new Random();
            int i = rnd.Next(1, 11);

            //Console.WriteLine(i);
            //Console.WriteLine(" ");

            Console.WriteLine("Game - guess the number.");
            

           
        
            Console.WriteLine(" ");
            Console.WriteLine("The program generates a random number from 1 to 10.");
            Console.WriteLine("Try to guess this number.");
            Console.WriteLine(" ");
            Console.WriteLine("Enter the number:");

            while (loopActive)
            {
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == i)
                {
                    Console.WriteLine($"Congratulations on your victory! you guessed it, it's a number " + userNumber + " ");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("try again:");
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("Have a nice day!");

        }

    }
}

