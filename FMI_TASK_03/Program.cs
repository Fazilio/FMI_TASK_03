using System;

namespace FMI_TASK_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "microsoft";
            string userPassword;
            int attempt = 3;

            Console.WriteLine("Введите пароль: ");

            for (attempt = 3; attempt >= 1; --attempt)
            {
                userPassword = Console.ReadLine();
                if (userPassword == password)
                {
                    Console.WriteLine("\nПоставьте 5 :)");
                    break;
                }
                else
                {
                    Console.WriteLine("Повторите попытку: ");
                }
            }
        }
    }
}
