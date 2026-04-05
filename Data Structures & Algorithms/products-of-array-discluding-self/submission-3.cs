public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        // products[] = prefix[] x suffix[]
        // prefix[] is everything to the left of index i
        // suffix[] is everything to the right of index i

        // Step 1: Build prefix[]
        var prefix = new int[nums.Length];
        prefix[0] = 1; // nothing to the left of index 0
        for (int i = 1; i < nums.Length; i++)
        {
            prefix[i] = prefix[i - 1] * nums[i - 1];
        }

        // Step 2: Build suffix[]
        var suffix = new int[nums.Length];
        suffix[nums.Length - 1] = 1;
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            suffix[i] = suffix[i + 1] * nums[i + 1];
        }

        // Step 3: Build products
        var products = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            products[i] = prefix[i] * suffix[i];
        }

        return products;
    }
}
