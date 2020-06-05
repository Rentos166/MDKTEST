using System;

namespace Виды_треугольников
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            Console.WriteLine("Программа определяет тип треугольника по введенным длинам сторон :");
            Console.WriteLine();
            Console.WriteLine("Пожалуйста, введите длину первой стороны треугольника :");
            double one = double.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите длину второй стороны треугольника :");
            double two = double.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите длину третьей стороны треугольника :");
            double three = double.Parse(Console.ReadLine());
            string getFormTrianling = triangle.FormTriangling(one, two, three);
            Console.WriteLine(getFormTrianling);
            Console.ReadKey();
        }
        public class Triangle
        {
            public string FormTriangling(double one, double two, double three)
            {
                if (one <= 0 || two <= 0 || three <= 0 || one + two <= three ||
                    one + three <= two || two + three <= one)
                {
                    return "Треугольника с такими сторонами не существует!!!";
                }
                if (one == two && one == three && two == three)
                {
                    return "Треугольник равносторонний!";
                }
                if (((one * one) == (two * two) + (three * three)) || ((two * two) == ((one * one) + 
                    (three * three)) || ((three * three) == (two * two) + (one * one))))
                {
                    return "Треугольник прямоугольный!";
                }
                if ((one == two && one != three) || (two == three && two != one) || 
                    (one == three && one != two))
                {
                    return "Треугольник равнобедренный!";
                }
                return "Треугольник разносторонний!";
            }
        }
        }
}
