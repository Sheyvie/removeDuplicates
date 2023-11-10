var removeDuplicates = function (nums) {
  if (nums.length === 0) {
    return 0; // If the array is empty, there are no duplicates.
  }

  let k = 1; // Initialize the count of unique elements.

  for (let i = 1; i < nums.length; i++) {
    if (nums[i] !== nums[i - 1]) {
      // If the current element is not equal to the previous one, replace the element at index k with it.
      nums[k] = nums[i];
      k++; // Increment k for each unique element.
    }
  }

  return k; // k is the number of unique elements.

  const nums1 = [1, 1, 2];
  const k1 = removeDuplicates(nums1);
  console.log(k1);
  console.log(nums1.slice(0, k1));

  const nums2 = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
  const k2 = removeDuplicates(nums2);
  console.log(k2);
  console.log(nums2.slice(0, k2));
};
