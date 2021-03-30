using System;
using System.Diagnostics.Tracing;

//write a c# sharp program that takes userid and password as input (type string). 
//after 3 wrong attempts, user will be rejected.
namespace Password
{
    class Program
    {

        class Password
        {
            public void GetPass(string Username, string PassW)
            {
                int counter = 3;
                do
                {
                    counter--;
                    if (Username == "Admin" && PassW == "Password")
                    {
                        counter = 0;
                        Console.WriteLine("Добро пожаловать, {0}", Username);
                    }
                    if (Username != "Admin" && PassW != "Password" && counter != 0)
                    {
                        Console.WriteLine("Неверный логин или пароль. У вас осталось {0} попыток", counter);
                        Username = Console.ReadLine();
                        PassW = Console.ReadLine();
                    }
                } while (counter > 0);
                if (Username != "Admin" && PassW != "Password" && counter == 0)
                {
                    Console.WriteLine("Сервис временно недоступен. Попробуйте позже.");
                }
            }
        }
        static void Main(string[] args)
        {
            Password instance = new Password();
            Console.WriteLine("Введите логин и пароль: ");
            instance.GetPass(Console.ReadLine(), Console.ReadLine());
        }
    }
}














































