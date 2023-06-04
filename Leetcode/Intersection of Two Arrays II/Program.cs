namespace Intersection_of_Two_Arrays_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int[] Intersect(int[] nums1, int[] nums2)
        {
            var num1Dictionary = new Dictionary<int, int>();
            foreach (int i in nums1)
            {
                if (num1Dictionary.ContainsKey(i))
                {
                    num1Dictionary[i]++;
                }
                else
                {
                    num1Dictionary[i] = 1;
                }
            }

            var listIntersect = new List<int>();
            foreach (int i in nums2)
            {
                if (num1Dictionary.ContainsKey(i))
                {
                    listIntersect.Add(i);
                    if (num1Dictionary[i] == 1)
                    {
                        num1Dictionary.Remove(i);
                    }
                    else
                    {
                        num1Dictionary[i]--;
                    }
                }
            }
            return listIntersect.ToArray();

        }
    }
}