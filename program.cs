using System;

public class Solution
{
  public int RemoveDuplicates(int[] nums)
  {
    if (nums.Length == 0)
    {
      return 0; // If the array is empty, there are no duplicates.
    }

    int k = 1; // Initialize the count of unique elements.

    for (int i = 1; i < nums.Length; i++)
    {
      if (nums[i] != nums[i - 1])
      {
        // If the current element is not equal to the previous one, replace the element at index k with it.
        nums[k] = nums[i];
        k++; // Increment k for each unique element.
      }
    }

    return k; // k is the number of unique elements.
  }

  static void Main(string[] args)
  {
    Solution solution = new Solution();

    int[] nums1 = { 1, 1, 2 };
    int k1 = solution.RemoveDuplicates(nums1);
    Console.WriteLine(k1); // Output: 2
    Console.WriteLine(string.Join(", ", nums1.Take(k1))); // Output: 1, 2

    int[] nums2 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
    int k2 = solution.RemoveDuplicates(nums2);
    Console.WriteLine(k2);
    Console.WriteLine(string.Join(", ", nums2.Take(k2)));
  }
}