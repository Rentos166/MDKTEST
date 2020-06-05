using System;

namespace Массив
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[10];
            Random rnd = new Random();
            for (int i = 0; i<10; i++)
            {
                x[i] = rnd.Next(-10, 10);
            }
            for (int i = 0; i<10; i++)
            {
                Console.WriteLine(x[i] + "");
            }
            Console.WriteLine();
            int min=x[0];
            for(int i = 1; i<x.Length; i++)
            {
                if (x[i]<min && x[i]>0)
                {
                    min = x[i];
                }
                Console.Write("Минимальные элементы массива: ");
                Console.WriteLine(min);
            }
            Console.ReadKey();
        }
    }
}
