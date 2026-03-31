public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (var i = 0; i < nums.Length; i++) {
            // Take target, subtract from smallest index (num), and find opposite number. If not exist, iterate
            var diff = target - nums[i];
            var index = Array.IndexOf(nums, diff, i + 1);
            if (index != -1) {
                return new[] { i, index };
            }
        }
        return Array.Empty<int>();
    }
}
