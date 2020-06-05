using System;

namespace Алфавит
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] polebia = {  {'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё'},
                                 {'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М'},
                                 {'Н', 'О', 'П', 'Р', 'С', 'Т', 'У'},
                                 {'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ'},
                                 {'Ы', 'Ь', 'Э', 'Ю', 'Я', '0', '1'},
                                 { '2','3', '4', '5', '6', '7', '8'},
                                 {'9', ' ', ',', '.', '!', '?', ';'}
                               };


            Console.WriteLine("Введите сообщение рускими буквами для шифровки: ");
            string s = Console.ReadLine();
            string new_s = "";



            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < polebia.GetLength(0); j++)
                    for (int k = 0; k < polebia.GetLength(1); k++)
                        if (Char.ToLower(polebia[j, k]) == s[i] || Char.ToUpper(polebia[j, k]) == s[i])
                        {
                            new_s += (Convert.ToString(j) + Convert.ToString(k));
                            break;
                        }

            }
            Console.WriteLine(new_s);

            Console.WriteLine("Введите код для расшифровки: ");
            string s1 = Console.ReadLine();
            string new_s1 = "";
            for (int a = 0; a < s1.Length; a += 2)
            {
                new_s1 += polebia[Convert.ToInt32(s1[a].ToString()), Convert.ToInt32(s1[a + 1].ToString())];
            }
            Console.WriteLine(new_s1);
        }
    }
}


