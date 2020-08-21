using System;
using System.Reflection.Metadata.Ecma335;

namespace massiv_12
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу сравнения возрастов!");
            for (; ; )
            {
                Console.Write("Введите имя первого человека: ");
                string name1 = Convert.ToString(Console.ReadLine());
                Console.Write("Введите возраст первого человека: ");
                int age1 = Convert.ToInt32(Console.ReadLine());
                if (age1 < 1)
                {
                    Console.WriteLine("Введены неправильные данные. Введите данные правильно! Возраст бывает положительным числом!");
                    continue;
                }
                Console.Write("Введите имя второго человека: ");
                string name2 = Convert.ToString(Console.ReadLine());
                Console.Write("Введите возраст второго человека: ");
                int age2 = Convert.ToInt32(Console.ReadLine());
                if (age2 < 1)
                {
                    Console.WriteLine("Введены неправильные данные. Введите данные правильно! Возраст бывает положительным числом!");
                    continue;
                }
                else
                {
                    for (; ; )
                    {
                        Console.WriteLine("Кто из них старше? (введите имя)");
                        string elder = Convert.ToString(Console.ReadLine());
                        if (elder == name1)
                        {
                            if (age1 > age2)
                            {
                                Console.WriteLine($"Вы ввели правильный ответ. {name1} старше {name2} на {age1 - age2} лет.");
                                break;
                            }
                            else if (age1 < age2)
                            {
                                Console.WriteLine($"Вы ввели не правильный ответ. Правильный ответ: {name2}. {name2} старше {name1} на {age2 - age1} лет.");
                                break;
                            }
                        }

                        else if (elder == name2)
                        {
                            if (age2 > age1)
                            {
                                Console.WriteLine($"Вы ввели правильный ответ. {name2} старше {name1} на {age2 - age1} лет.");
                                break;
                            }
                            else if (age2 < age1)
                            {
                                Console.WriteLine($"Вы ввели не правильный ответ. Правильный ответ: {name1}. {name1} старше {name2} на {age1 - age2} лет.");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Введено неверное имя!");
                            continue;
                        }
                    }
                }
                break;
            }
        }
    }
}
