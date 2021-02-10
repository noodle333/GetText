using System;
using System.Collections.Generic;

namespace GetText
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wordList = new List<string>();

            int i = 0;
            while (i <= 4)
            {
                string myString = GetText(2, 7);
                wordList.Add(myString);
                i++;
            }

            wordList.Reverse();
            foreach (string word in wordList)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }
        static string GetText(int min, int max)
        {
            bool complete = false;
            while (complete == false)
            {
                Console.WriteLine("Skriv in ett ord mellan " + min + " och " + max + " bokstäver långt.");
                string myInput = Console.ReadLine();

                if (myInput.Length >= min && myInput.Length <= max)
                {
                    return myInput;
                }
            }
            return "";
        }
    }
}
