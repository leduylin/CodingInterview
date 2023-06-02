namespace Remove_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
            RemoveElement2(nums, 2);
        }
        public static int RemoveElement(int[] nums, int val)
        {
            int count = 0;
            List<int> differentValues = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    count++;
                    differentValues.Add(nums[i]);
                }
            }
            for (int i = 0; i < differentValues.Count; i++)
            {
                nums[i] = differentValues[i];
            }
            return count;
        }

        public static int RemoveElement2(int[] nums, int val)
        {
            var res = (from num in nums
                       where num != val
                       select num).ToArray();
            for (int i = 0; i < res.Length; i++)
            {
                nums[i] = res[i];
            }
            return res.Length;
        }

    }
}