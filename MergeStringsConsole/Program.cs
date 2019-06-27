using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeStringsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = string.Empty;
            string secondWord = string.Empty;

            StringBuilder initial = new StringBuilder();
            initial.AppendLine("*********************************************");
            initial.AppendLine("*****Application for merging two strings*****");
            initial.AppendLine("*********************************************");
            initial.AppendLine();

            Console.Write(initial);

            while (string.IsNullOrWhiteSpace(firstWord))
            {
                Console.Write("Please type the first word: \n");
                firstWord = Console.ReadLine();
            }

            while (string.IsNullOrWhiteSpace(secondWord))
            {
                Console.Write("Please type the second word: \n");
                secondWord = Console.ReadLine();
            }

            string mergedWord = MergeStrings(firstWord, secondWord);

            Console.Write($"The merged word is: {mergedWord}");
            Console.ReadLine();
        }

        public static string MergeStrings(string firstWord, string secondWord)
        {
            string mergedResult = string.Empty;
            int firstLength = firstWord.Length;
            int secondLength = secondWord.Length;
            int limit = 0;

            if (firstLength > secondLength)
            {
                limit = firstLength;
            }
            else if (firstLength < secondLength)
            {
                limit = secondLength;
            }
            else
            {
                limit = firstLength;
            }

            for (int i = 0; i < limit; i++)
            {
                if (i == 0)
                {
                    mergedResult = $"{firstWord[i]}{secondWord[i]}";
                }
                else
                {
                    if (i < firstLength)
                    {
                        mergedResult += firstWord[i];
                    }

                    if (i < secondLength)
                    {
                        mergedResult += secondWord[i];
                    }
                }
            }

            return mergedResult;
        }
    }
}
