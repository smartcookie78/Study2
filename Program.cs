using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rubToUsd = 88.43;
            double usdToRub = 90.43;
            double numberOfRub;
            double numberOfUsd;
            double totalUsd = 100;
            double totalRub = 1000;

            string answer;

            Console.WriteLine("Какую операцию вы хотите выполнить?");
            Console.WriteLine("1 - Rub to USD");
            Console.WriteLine("2 - USD to Rub?");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                Console.WriteLine("Выбрана операция Rub to USD");
                Console.WriteLine("Сколько рублей вы хотите конвертировать?");
                numberOfRub = Convert.ToSingle(Console.ReadLine());

                if (numberOfRub > totalRub) 
                {
                    Console.WriteLine("Введено неверное количество рублей");                   
                }
                else
                {
                    totalUsd = numberOfRub / rubToUsd;
                    totalRub -= numberOfRub;
                    Console.WriteLine($"Ваш баланс {Math.Round(totalUsd, 2)} долларов и {totalRub} рублей");
                    Console.WriteLine("Спасибо за пользование нашим сервисом!");
                }

            }
            else if (answer == "2")
            {
                Console.WriteLine("Выбрана операция UDS to RUB");
                Console.WriteLine("Сколько долларов вы хотите конвертировать?");
                numberOfUsd = Convert.ToSingle(Console.ReadLine());
                if (numberOfUsd >  totalUsd)
                {
                    Console.WriteLine("У Вас недостаточно долларов для конвертации");
                }
                else
                { 
                    totalRub = numberOfUsd * usdToRub;
                    totalUsd -= numberOfUsd;
                    Console.WriteLine($"Ваш баланс {Math.Round(totalUsd, 2)} долларов и {Math.Round(totalRub, 2)} рублей");
                    Console.WriteLine("Спасибо за пользование нашим сервисом!");
                }

               
            }
        Console.ReadKey();


        C:\Users\user\source\repos\C#\Study2\Study2.sln   
        }
        
    }
}
