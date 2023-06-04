namespace Contains_Duplicate
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public bool ContainsDuplicate(int[] nums)
        {
            var distinct = nums.Distinct();
            if (distinct.Count() == nums.Length)
            {
                return false;
            }
            return true;
        }
    }
}