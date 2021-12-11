using System;

namespace Rab_006_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры предложение. Предложение представляет собой слова,
            //разделенные пробелом. Знаки препинания не используются.
            //Найти самое длинное слово в строке.

            Console.WriteLine("Введите с клавиатуры предложение");
            Console.WriteLine();
            string str = Console.ReadLine();
            string[] word = str.Split(' ');

            string a = "";
            int b = 0;
            foreach (string s in word)
            {
                if (s.Length > b)

                {
                    a = s;
                    b = s.Length;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Самое длинное слово в предложении");
            Console.WriteLine();
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
