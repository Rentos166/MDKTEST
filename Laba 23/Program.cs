using System;

namespace Laba_23
{
    struct ZNAK
    {
        public string firstname;
        public string secondname;
        public string zodiac;
        public int birthDay;
        public int birthM;
        public int birthYear;

        public ZNAK(string Firstname, string Secondname, string Zodiac, int BirhDay, int BirthM, int BirthYear)
        {
            this.firstname = Firstname;
            this.secondname = Secondname;
            this.zodiac = Zodiac;
            this.birthDay = BirhDay;
            this.birthM = BirthM;
            this.birthYear = BirthYear;
        }
        public override string ToString()
        {
            return (string.Format(@"
                Имя: {0}
                Фамилия: {1}
                Знак: {2}
                Дата рождения: {3}, {4}, {5}", firstname, secondname, zodiac, birthDay, birthM, birthYear
                ));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            ZNAK[] x = new ZNAK[a];
            for (int i = 0; i<a; i++)
            {
                Console.Write("Введите имя: ");
                x[i].firstname = Console.ReadLine();
                Console.Write("Введите фамилию: ");
                x[i].secondname = Console.ReadLine();
                Console.Write("Введите знак зодиака: ");
                x[i].zodiac = Console.ReadLine();
                Console.Write("Введите день рождения: ");
                x[i].birthDay = int.Parse(Console.ReadLine());
                Console.Write("Введите месяц рождения: ");
                x[i].birthM = int.Parse(Console.ReadLine());
                Console.Write("Введите год рождения: ");
                x[i].birthYear = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i<a; i++)
            {
                for (int j = 0; j<a-1-i; j++)
                {
                    if (x[i].birthYear > x[j].birthYear)
                    {
                        ZNAK temp = x[i];
                        x[i] = x[j];
                        x[j] = temp;
                    }
                }
            }
            Console.WriteLine("Информация:");
            for (int i = 0; i<a; i++)
            {
                Console.WriteLine(x[i]);
            }
            string familia;
            Console.WriteLine("Введите фамилию человека: ");
            familia = Console.ReadLine();
            for(int i = 0; i<a; i++)
            {
                if(x[i].secondname == familia)
                {
                    Console.WriteLine(x[i]);
                }
                else
                {
                    Console.WriteLine("Такого человека нет");
                }
                break;
            }
            Console.ReadKey();
        }
    }
}
