using System;

namespace GuessingGameThreeThries
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
            // У пользователя ровно три попытки
            // Если пользователь не угадывает число за три попытки, программа обьявдяет победителем компьютер
            // случайное число генерируется только один раз

            Random rand = new Random();
            int i = rand.Next(1, 11);
            int tries = 1;
            Console.WriteLine("Game - guess the number.");
            Console.WriteLine("The computer guessed a number from 1 to 10.");
            Console.WriteLine("Try to guess this number. You have three tries.");
            Console.WriteLine("");
            Console.WriteLine("Attempt N1:");

            int userNumber = Convert.ToInt32(Console.ReadLine());
            while (tries <= 3)
            {
                if (i == userNumber)
                {
                    Console.WriteLine($"Yes! The hidden number" + userNumber + "!" + " ");
                    Console.WriteLine("Congradulations!");
                    break;

                }
                else
                {
                    tries++;
                    if (tries == 4)
                    {
                        Console.WriteLine("Unfortunetly, you did not guess the hidden number. It was a number" + i + "!");
                        Console.WriteLine("This time the computer win!");
                        break;







                    }
                    Console.WriteLine($"No, this number is not" + userNumber + " ");
                    Console.WriteLine("");
                    Console.WriteLine($"Attempt N" + tries + " ");
                    userNumber = Convert.ToInt32(Console.ReadLine());



                }

            }
            Console.WriteLine("");
            Console.WriteLine("Have a nice day!");






        }
    }
}
