using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace method_age
{
    class Program
    {

        static void Main(string[] args)
        {
            string report = "первого";
            string name1 = AskName(report);
            int age1 = AskAge(report);

            report = "второго";
            string name2 = AskName(report);
            int age2 = AskAge(report);

            Compare(name1, name2, age1, age2);
        }

        static string AskName(string number)
        {
            Console.Write($"Введите имя {number} человека: ");
            string name = Console.ReadLine();
            return name;
        }

        static int AskAge(string number)
        {
            int age = 0;
            for (; ; )
            {
                Console.Write($"Введите возраст {number} человека: ");
                age = Convert.ToInt32(Console.ReadLine());
                if (age < 1)
                {
                    Console.WriteLine("Введите данные заново. Введенные данные неверны. Возраст должен быть положительным!");
                    continue;
                }
                else
                {
                    break;
                }
            }
            return age;
        }

        static void Compare(string name1a, string name2a, int age1a, int age2a)
        {
            for (; ; )
            {
                Console.WriteLine("Кто из них старше?");
                string elder = Convert.ToString(Console.ReadLine());
                if (elder == name1a)
                {
                    if (age1a > age2a)
                    {
                        Console.WriteLine($"Вы ввели правильный ответ. {name1a} старше {name2a} на {age1a - age2a} лет.");
                        break;
                    }
                    else if (age1a < age2a)
                    {
                        Console.WriteLine($"Вы ввели не правильный ответ. Правильный ответ: {name2a}. {name2a} старше {name1a} на {age2a - age1a} лет.");
                        break;
                    }
                    break;
                }
                else if (elder == name2a)
                {
                    if (age2a > age1a)
                    {
                        Console.WriteLine($"Вы ввели правильный ответ. {name2a} старше {name1a} на {age2a - age1a} лет.");
                        break;
                    }
                    else if (age2a < age1a)
                    {
                        Console.WriteLine($"Вы ввели не правильный ответ. Правильный ответ: {name1a}. {name1a} старше {name2a} на {age1a - age2a} лет.");
                        break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Введите верное имя!");

                }
                break;
            }

        }
    }
}

