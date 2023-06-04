namespace First_Unique_Character_in_a_String
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int FirstUniqChar(string s)
        {
            int result = -1;
            Dictionary<char, int> charExist = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (charExist.ContainsKey(c))
                {
                    charExist[c]++;
                }
                else
                {
                    charExist.Add(c, 1);
                }
            }
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                count = charExist[s[i]];
                if (count == 1)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
    }
}