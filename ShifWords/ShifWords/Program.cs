using System;

namespace ShifWords
{
    internal class Program
    {
        static string ReverseWord(string inputPhrase)
        {
            string resultString = "";
            string newString;
            string [] reversedArr = SplitWords(inputPhrase);
            for (int i = reversedArr.Length - 1; i >= 0; i--)
            {
                newString = reversedArr[i];
                resultString += newString + " ";
            }
            Console.WriteLine(resultString);
            return resultString;
        }

        static string[] SplitWords(string inputPhrase)
        {
            string[]input = inputPhrase.Split(' ');
            return input;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string inputPhrase = Console.ReadLine();
            ReverseWord(inputPhrase);
        }
    }
}
