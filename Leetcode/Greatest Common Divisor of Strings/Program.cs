using System.Text;

namespace Greatest_Common_Divisor_of_Strings
{
    public class Program
    {
        static void Main(string[] args)
        {
            GcdOfStrings("ABCABCH", "ABC");
        }

        public static string GcdOfStrings(string str1, string str2)
        {
            int gcd = calculateGCD(str1.Length, str2.Length);

            string gcdString = str2.Substring(0, gcd);
            for (int i = 0; i < str1.Length; i += gcd)
            {
                var currentSt = str1.Substring(i, gcd);
                if (!currentSt.Equals(gcdString))
                {
                    return "";
                }
            }
            for (int i = 0; i < str2.Length; i += gcd)
            {
                var currentSt = str2.Substring(i, gcd);
                if (!currentSt.Equals(gcdString))
                {
                    return "";
                }
            }
            return gcdString;
        }

        static int calculateGCD(int x, int y)
        {
            if (y == 0)
                return x;
            return calculateGCD(y, x % y);
        }

    }
}