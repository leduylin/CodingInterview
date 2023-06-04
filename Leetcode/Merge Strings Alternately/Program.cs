using System.Text;

namespace Merge_Strings_Alternately
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MergeAlternately("abcd", "pq"));
        }

        public static string MergeAlternately(string word1, string word2)
        {
            int lengthFirstWord = word1.Length;
            int lengthSecondWord = word2.Length;
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0, j = 0; i < lengthFirstWord && j < lengthSecondWord; i++, j++)
            {
                stringBuilder.Append(word1[i].ToString() + word2[j].ToString());
            }
            if (lengthFirstWord > lengthSecondWord)
            {
                for (int i = lengthSecondWord; i < lengthFirstWord; i++)
                {
                    stringBuilder.Append(word1[i].ToString());
                }
            }
            else if (lengthSecondWord > lengthFirstWord)
            {
                for (int i = lengthFirstWord; i < lengthSecondWord; i++)
                {
                    stringBuilder.Append(word2[i].ToString());
                }
            }
            return stringBuilder.ToString();
        }

    }
}