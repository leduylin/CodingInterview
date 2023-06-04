namespace Remove_Duplicates_from_Sorted_Array
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int RemoveDuplicates(int[] nums)
        {
            var res = (from num in nums
                       select num).Distinct().ToList();
            for (int i = 0; i < res.Count; i++)
            {
                nums[i] = res[i];
            }
            return res.Count;

        }
    }
}