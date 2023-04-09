using System.Runtime.CompilerServices;

namespace _04._08._2023_20._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();

            Console.WriteLine(Correct(sentence));
        }
        public static string Correct(string sentence)
        {
            string CorrectSentence = sentence;
            string[] words = CorrectSentence.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }

            return string.Join(" ", words);
        }
    }
}
