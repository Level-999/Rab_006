using System;

namespace Rab_006_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры предложение. Предложение представляет собой слова,
            //разделенные пробелом. Знаки препинания не используются. Составить программу,
            //определяющую является ли строка палиндромом без учёта пробелов и регистра
            //(пример палиндрома – «арозаупаланалапуазора»).

            string str = Console.ReadLine();
            string revStr = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                revStr += str[i];
            }
            Console.WriteLine();
            if (str == revStr)
                Console.WriteLine("Строка является палиандромом");
            else
                Console.WriteLine("Строка не является палиандромом");


            Console.ReadKey();
        }
    }
}
