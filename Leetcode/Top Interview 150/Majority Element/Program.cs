namespace Majority_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int MajorityElement(int[] nums)
        {
            int standard = (int)Math.Floor((double)nums.Length / 2);
            var groupNum = nums.GroupBy(i => i);
            int res = 0;
            foreach (var keyVal in groupNum)
            {
                if (keyVal.Count() > standard)
                {
                    res = keyVal.Key;
                    break;
                }
            }
            return res;
        }
    }
}