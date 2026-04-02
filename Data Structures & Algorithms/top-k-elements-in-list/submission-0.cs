public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        foreach (int num in nums) {
            if (counts.ContainsKey(num)) counts[num]++;
            else counts[num] = 1;
        }

        return counts.OrderByDescending(x => x.Value)
                     .Take(k)
                     .Select(x => x.Key)
                     .ToArray();
    }
}
