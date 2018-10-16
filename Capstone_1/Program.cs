using System;

namespace Capstone_1
{
    class Program
    {

        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a word or phrase to translate to PigLatin:");
            string userInput = Console.ReadLine();
            var pigLatin = GetSentenceInPigLatin(userInput);
            Console.WriteLine(pigLatin);
            Console.ReadLine();
        }

        private static string GetSentenceInPigLatin(string userInput)
        {
            const string vowels = "AEIOUaeiou";
            var returnSentence = "";
            foreach (var word in userInput.Split())
            {
                var firstLetter = word.Substring(0, 1);
                var restOfWord = word.Substring(1, word.Length - 1);
                var currentLetter = vowels.IndexOf(firstLetter, StringComparison.Ordinal);

                if (currentLetter == -1)
                {
                    returnSentence += restOfWord + firstLetter + "ay ";
                }
                else
                {
                    returnSentence += word + "way ";
                }
            }
            return returnSentence;
        }
    }
}