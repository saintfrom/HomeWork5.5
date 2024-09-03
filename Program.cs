using System;

namespace HomeWork5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинное предложение");
            ReverseWords(Console.ReadLine());
        }
        static string ReverseWords(string inputPhrase)
        {
            string[] income = SplitText(inputPhrase);
            Array.Reverse(income);
            string reversed = string.Join(" ", income);
            Console.WriteLine(reversed);
            return reversed;
        }
        static string[] SplitText(string text)
        {
            char[] separator = new char[] { ' ' };
            string[] splitPhrase = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            foreach (string phrase in splitPhrase)
                Console.WriteLine(phrase);
            return splitPhrase;
        
        }
    }
}
