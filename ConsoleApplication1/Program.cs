using System;
using System.Collections.ObjectModel;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(1251);

            int[,] array = new int [5, 5];
            Random rand = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(0, 100);
                    Console.Write(array [i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}