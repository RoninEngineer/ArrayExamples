using System;

namespace ArrayFunctions 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 5, 4, 3, 2, 1 };
            
            // Zero duplicates in array
            var zeroedDups = ZeroDuplicates(nums);
            Array.ForEach(zeroedDups, Console.Write);
            Console.ReadLine();

            // Find duplicates in array
            int[] dupes = { 1, 2, 3, 4, 5, 6, 5, 4, 3, 2, 1 };
            var noDupes = FindDuplicates(dupes);
            Array.ForEach(noDupes, Console.Write);
            Console.ReadLine();

            // Use .Net Array Namespace BinarySearch method
            int[] searches = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32 };
            var searchIndex = BinarySearchForValue(searches, 3);
            Array.ForEach(searches, Console.Write);
            Console.WriteLine();
            Console.WriteLine($"Search index returned : {searchIndex}");
            Console.ReadLine();

            // Reverses contents of array
            int[] reverses = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var result = ReverseArray(reverses); 
            Array.ForEach(result, Console.Write);
            Console.ReadLine();
        }

        public static int[] ZeroDuplicates(int[] nums)
        {
            var temp = new HashSet<Int32>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (temp.Contains(nums[i]))
                {
                    nums[i] = 0;
                }
                temp.Add(nums[i]);
            }
            return nums;
        }

        public static int[] FindDuplicates(int[] nums)
        {
            var temp = new HashSet<Int32>();

            for(int i = 0; i < nums.Length; i++)
            {
                if(!temp.Contains(nums[i]))
                {
                    temp.Add(nums[i]);
                }
            }
            return temp.ToArray();
        }

        public static int BinarySearchForValue(int[] nums, object locateValue)
        {
            Array.Sort(nums);
            int itemIndex = Array.BinarySearch(nums, locateValue);
            return itemIndex;

        }

        public static int[] ReverseArray(int[] nums)
        {
            Array.Reverse(nums);
            return nums;
        }

        
    }
}