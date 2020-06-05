using System;

namespace Тест_строк
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string a = Console.ReadLine();
            Console.WriteLine(a.Replace("Ренат", "Юра"));
            Console.ReadKey();
        }
    }
}
