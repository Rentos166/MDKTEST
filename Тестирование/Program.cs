using System;

namespace Тестирование
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            Console.WriteLine("Введите значение а: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение c: ");
            c = Convert.ToDouble(Console.ReadLine());
            double d = b * b - 4 * a * c;
            if (a == 0.0)
            {
                double x = -c / b;
                Console.WriteLine("х = " + x);
            }
            else if (b == 0.0 && -c / a > 0.0)
            {
                double x1 = Math.Sqrt(-c / a);
                double x2 = -Math.Sqrt(-c / a);
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else if (d == 0.0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("х = " + x);
            }
            else if (d>0.0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else
            {
                Console.WriteLine("Дискриминант < 0. Корней нет!");
            }
            Console.ReadKey();
        }
    }
}
