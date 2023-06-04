namespace Remove_Duplicates_from_Sorted_Array_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
            var res = RemoveDuplicates(ints);
        }

        public static int RemoveDuplicates(int[] nums)
        {
            var countTimeExist = nums.GroupBy(x => x);
            int index = 0;
            foreach (var keyValue in countTimeExist)
            {
                int key = keyValue.Key;
                int value = keyValue.Count();
                for (int i = 0; i < value && i < 2; i++)
                {
                    nums[index] = key;
                    index++;
                }
            }
            for (int i = 0; i < index; i++)
            {
                Console.Write(nums[i]);
            }
            return index;
        }
    }
}