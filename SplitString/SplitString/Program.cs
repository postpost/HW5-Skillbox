using System;

namespace SplitString
{
    class Program
    {
        /// <summary>
        /// Метод, возвращающий массив из строковой переменной
        /// </summary>
        /// <param name="inputPhrase">Введенное предложение</param>
        /// <returns>Возвращает массив слов</returns>
        static string[] SplitString(string inputPhrase)
        {
            
            string[] arr = inputPhrase.Split(' ');
            PrintArray(arr);
            return arr;

        }

        /// <summary>
        /// Метод, выводящий массив в консоль
        /// </summary>
        /// <param name="inputString">Массив, который необходимо распечатать</param>
        static void PrintArray(string[] inputString)
        {
            foreach (var e in inputString) Console.WriteLine(e);
        }

        ////static void Split01(params string[] arr)
        ////{
        ////    Console.WriteLine("Type a sentence");
        ////    string input = Console.ReadLine();
        ////    var word = string.Empty;
        ////    for (int j = 0; j < input.Length; j++)
        ////    {
        ////        if (input[j] != ' ')
        ////        {
        ////            word += input[j];
        ////        }
        ////        else 
        ////        {
        ////            Console.WriteLine();
        ////            arr[j] = word;
        ////        }
        ////    PrintArray(arr);
        ////}

        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string inputPhrase = Console.ReadLine();
            SplitString(inputPhrase);
            ////Split01();
        }
    }
}

