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

            Random rand = new Random();
            int i;
            int c = 0;
            int a;

            Console.Write("Введите уровень заточки от 1 до 12: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a <= 12)
            {
                while (true)
                {
                    i = rand.Next(0, 2);
                    Console.WriteLine(i);
                    if (i == 1)
                    {
                        c++;
                        if (c == a)
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
            else
            {
                Console.WriteLine("Хорошая попытка! Но все же введите значение от 1 до 12");
            }
        }
    }
}