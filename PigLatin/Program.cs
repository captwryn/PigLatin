using System;

namespace NumAnalyze1
{
    class Program
    {
        static bool IsVowel(char letter)
        {
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string PigLatin(string text)

        {
            int firstVowel = -1;
            for (int i = 0; i < text.Length; i++)
            {
                if (IsVowel(text[i]))
                {
                    firstVowel = i;
                    break;
                }
            }
            string final = null;
            
            if (firstVowel == 0)
            {
                final = $"{text.Substring(firstVowel)}way";
            }
            else
            {
                final = $"{text.Substring(firstVowel)}{text.Substring(0, firstVowel)}ay";
            }
            return final;

        }

        static void Main(string[] args)
        {
            int x = 1;
            Console.WriteLine("Let's translate to Pig Latin.");

            while (x == 1)
            {
                
                Console.Write("Please enter a word:");
                string text = Console.ReadLine().ToLower();

                Console.WriteLine(PigLatin(text));

                Console.WriteLine("Would you like to go again(y/n)?");
                string again = Console.ReadLine();
                if (again != "y")
                {
                    x = 2;
                }
            }
        }
    }
}
