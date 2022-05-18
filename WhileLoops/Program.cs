using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // программа просит пользователя ввести ПИН - код 
            // программа проверяет, соответствует ли введенный ПИН-код значению "1234"
            // если введенное значение соответсивует "1234", в консоле выводится "Welcome!"
            // и программа завершает свою работу
            // если введенный ПИН-кол неверный, то программа просит снова ввести ПИН-код
            // у пользователя 3 попытки

            bool loopActive = true;
           int tries = 0;



            while (loopActive)
            {
                if (tries == 3)// != не равно 
                {
                    Console.WriteLine($"You have tried to log in {tries} times. Login failed.");
                    break;
                }
                Console.WriteLine("Enter yor PIN:");
                string userPin = Console.ReadLine();

                if(userPin == "1234")
                {
                    Console.WriteLine("Welcome!");
                    break;
                } 
                else
                {
                    Console.WriteLine("Envalid PIN. Try again.");
                    tries++;
                    Console.WriteLine($"You have made {tries} attempts. ");
                }
            }

            Console.WriteLine("Have a nice day!");

           
            
           
        }
    }
}
