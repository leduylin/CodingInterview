using System.Text;
using System.Collections.Generic;


namespace Merge_Sorted_Array
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            var m = 3;
            var nums2 = new int[] { 2, 5, 6 };
            var n = 3;
            Merge(nums1, m, nums2, n);
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            List<int> mergedSortedList = new List<int>();
            int i = 0, j = 0;
            for (; i < m && j < n;)
            {
                if (nums1[i] <= nums2[j])
                {
                    mergedSortedList.Add(nums1[i]);
                    i++;
                }
                else
                {
                    mergedSortedList.Add(nums2[j]);
                    j++;
                }
            }
            if (i <= (m - 1))
            {
                for (; i < m; i++)
                {
                    mergedSortedList.Add(nums1[i]);
                }
            }
            else if (j <= (n - 1))
            {
                for (; j < n; j++)
                {
                    mergedSortedList.Add(nums2[j]);
                }
            }
            for (int k = 0; k < (m + n); k++)
            {
                nums1[k] = mergedSortedList[k];
            }
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