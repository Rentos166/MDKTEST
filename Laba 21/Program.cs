using System;

namespace Laba_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }
        public void Person(int anAge, int aYear)
        {
            if (anAge < 0)
                throw new PersonException(PersonException.NEGATIVE_AGE);
            age = anAge;
            if (aYear > DateTime.Now.Year)
                throw new PersonException(PersonException.NEGATIVE_YEAR);
            year = aYear;
        }

        public int Age
        {
            get { return age; }
            set
            {
                //Если указан отрицательный возраст
                if (value < 0)
                    throw new PersonException(PersonException.NEGATIVE_AGE);
                age = value;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                //Если указан год меньше текущего
                if (value > DateTime.Now.Year)
                    throw new PersonException(PersonException.NEGATIVE_YEAR);
                year = value;
            }
        }
        private int age;
        private int year;

        public void Read()
        {
            double R1 = Convert.ToDouble(Console.ReadLine());
            double R2 = Convert.ToDouble(Console.ReadLine());
            int R3 = Convert.ToInt32(Console.ReadLine());
            double rez = Math.Sin(R1) * Math.PI / R2 - R3;
            Console.WriteLine(rez);
            Console.ReadKey();
        }
        class PersonException : Exception //Используем наследование
        {
            //Массив описаний ошибок
            private static string[] descriptions = new string[]
            {
          "Указано отрицательное число в качестве возраста",
          "Указан год рождения больше текущего"
            };
            public const int NEGATIVE_AGE = 0; //Отрицательный возраст
            public const int NEGATIVE_YEAR = 1;

            public PersonException(int anErrorCode)
            {
                errorCode = anErrorCode;
            }

            public override string Message
            {
                get
                {
                    //Если указан некорректный код ошибки, или вообще не указан
                    if (errorCode < 1 || errorCode > descriptions.Length - 1)
                        return descriptions[0];
                    return descriptions[errorCode];
                }
            }
            //Возвращает код ошибки
            public int ErrorCode { get { return errorCode; } }
            //Код ошибки
            private int errorCode;
        }
    }
}
