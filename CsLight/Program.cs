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

            int numberOfAttempts = 4; // Кількість спроб при неудачному вводі значення
            for (int i = numberOfAttempts; i > 0; i--)

            {
                Random rand = new Random();
                int a;
                int c = 0;
                int level;

                Console.Write("Введіть рівень заточки від 1 до 12: ");
                level = Convert.ToInt32(Console.ReadLine());
                if (level >= 1 && level <= 12)
                {
                    while (true)
                    {
                        a = rand.Next(0, 2);
                        Console.WriteLine(a);
                        if (a == 1)
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

                    break;
                }
                else
                {
                    Console.WriteLine(
                        "Введено некоректне значення. Будь ласка, введіть значення від 1 до 12! \nУ Вас залишилось " +
                        (i - 1) + " спроб ");
                    if (i > 1)
                    {
                        Console.WriteLine("Повторити?\n1 - Так.\n2 - Ні.");
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 1 :
                                break;
                            case 2 :
                                i = 0;
                                break;
                        }
                        // Console.ReadKey();
                        // // if (Console.ReadKey(true).Key == ConsoleKey.Y) ;
                    }
                    else
                    {
                        Console.WriteLine("Всі ми колись помиляємось");
                    }
                }
            }
        }
    }
}