using System.Text;

namespace Assignment7_1_2
{
    internal class Program
    {
        //You are given two strings word1 and word2.
        //Merge the strings by adding letters in alternating order, starting with word1.
        //If a string is longer than the other, append the additional letters onto the end of the merged string.
        //Return the merged string.
        static void Main(string[] args)
        {
            string word1 = "Operate";
            string word2 = "Chemical";
            Console.WriteLine($"First word:  { word1 }");
            Console.WriteLine();
            Console.WriteLine($"Second word:  { word2 }");
            Console.WriteLine();
            Console.WriteLine($"Merged word:  { MergeWords(word1, word2) }");
        }

        //Find the shortest and longest word, loop until i < longest word length.
        //append word1[i] then word2[i] if 1 is less than the shortest word length.
        //else append i of longest word, return merged string
        static string MergeWords(string word1, string word2)
        {
            StringBuilder sb = new StringBuilder();
            int word1Len = word1.Length;
            int word2Len = word2.Length;
            int longestLen = Math.Max(word1Len, word2Len);

            for (int i = 0; i < longestLen; i++)
            {
                if (i < word1Len)
                {
                    sb.Append(word1[i]);
                }
                if (i < word2Len)
                {
                    sb.Append(word2[i]);
                }
            }

            return sb.ToString();
        }
    }
}
