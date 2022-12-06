using System;
using System.Diagnostics.Eventing.Reader;

namespace CsLight
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(1251);

            Console.WriteLine("Генератор заточки");
            while (true)
            {
                Random rand = new Random();
                int i;
                int c = 0;
                int level;

                Console.Write("Введите уровень заточки от 1 до 12: ");
                level = Convert.ToInt32(Console.ReadLine());
                if (level <= 0 || level > 12)
                {
                    Console.WriteLine("Введено некорректное значение. Пожалуйста, введите значение от 1 до 12!");
                    Console.WriteLine("Повторить? y/n");
                    if (Console.ReadKey(true).Key != ConsoleKey.Y)
                        break;
                }
                else
                {
                    while (true)
                    {
                        i = rand.Next(0, 2);
                        Console.WriteLine(i);
                        if (i == 1)
                        {
                            c++;
                            if (c == level)
                            {
                                break;
                            }
                        }
                        else
                        {
                            c = 0;
                        }
                    }
                }
            }
        }
    }
}