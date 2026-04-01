public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var hash = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (hash.Contains(complement))
            {
                return new int[] { Array.IndexOf(nums, complement), i };
            }
            hash.Add(nums[i]);
        }
        throw new ArgumentException("No two sum solution");
    }
}
