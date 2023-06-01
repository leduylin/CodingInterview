namespace EIUGIFT1___Gift_Wrapping
{
    public class Program
    {
        static void Main(string[] args)
        {
            Reader reader = new Reader();
            int n = reader.NextInt(), m = reader.NextInt();
            List<int> cubeSizes = new List<int>();
            List<int> paperSizes = new List<int>();
            for (int i = 0; i < n; i++)
            {
                cubeSizes.Add(reader.NextInt());
            }
            for (int i = 0; i < m; i++)
            {
                paperSizes.Add(reader.NextInt());
            }
            cubeSizes.Sort();
            paperSizes.Sort();
            //cubeSizes = cubeSizes.OrderBy(i => i).ToList();
            //paperSizes = paperSizes.OrderBy(i => i).ToList();

            int maxNumberOfGifts = 0;
            for (int i = 0, j = 0; i < n && j < m;)
            {
                double sizeGap = (double)paperSizes[j] / cubeSizes[i];
                if (sizeGap >= 2 && sizeGap <= 3)
                {
                    maxNumberOfGifts++;
                    i++;
                    j++;
                }
                else if (sizeGap > 3)
                {
                    i++;
                }
                else if (sizeGap < 2)
                {
                    j++;
                }
            }
            Console.WriteLine(maxNumberOfGifts);
        }
    }

    class Reader
    {
        private int index = 0;
        private string[] tokens;
        public string Next()
        {
            while (tokens == null || tokens.Length <= index)
            {
                tokens = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                index = 0;
            }
            return tokens[index++];
        }
        public int NextInt()
        {
            return int.Parse(Next());
        }

        public double NextDouble()
        {
            return double.Parse(Next());
        }
    }
}