using System;

namespace FinGram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Вы зарегистрировались?");
            Console.WriteLine("Ответ:");
            string answer = Console.ReadLine();
            if (answer == "да" || answer == "ДА" || answer == "Да")
            {
                Console.WriteLine("Введите логин:");
                string answerLogin = Console.ReadLine();
                Console.WriteLine("Введите пароль:");
                string answerPassword = Console.ReadLine();
            }


        }
    }
}
