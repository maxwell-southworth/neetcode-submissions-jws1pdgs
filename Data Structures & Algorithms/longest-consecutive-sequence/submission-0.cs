// LONGEST CONSECUTIVE SEQUENCE
//
// Goal: find the length of the longest run of consecutive integers (e.g. 1,2,3,4)
//
// Step 1: Load all numbers into a HashSet
//         - this lets us check if any number exists in O(1)
//
// Step 2: Loop through each number in the set
//         - skip it if (n - 1) exists in the set
//           → it's not a sequence start, someone before it already owns this sequence
//
// Step 3: If it IS a sequence start, walk forward:
//         - keep a local length counter starting at 1
//         - while the set contains (n + length), increment length
//
// Step 4: Update a running max if this sequence is the longest seen so far
//
// Step 5: Return the max
//
// Example: [100, 4, 200, 1, 3, 2]
//   HashSet: {100, 4, 200, 1, 3, 2}
//   n=100 → 99 not in set → walk: 101? no → length=1
//   n=4   → 3 in set     → skip
//   n=200 → 199 not in set → walk: 201? no → length=1
//   n=1   → 0 not in set  → walk: 2? yes, 3? yes, 4? yes, 5? no → length=4
//   n=3   → 2 in set     → skip
//   n=2   → 1 in set     → skip
//   max = 4 ✓
//
// Time:  O(n) — each number is visited at most twice (once in outer loop, once in a walk)
// Space: O(n) — the HashSet
public class Solution {
    public int LongestConsecutive(int[] nums)
    {
        var hashSet = new HashSet<int>(nums);
        var max = 0;

        foreach (var n in hashSet)
        {
            // skip if n-1 exists, this isn't a sequence start
            if (hashSet.Contains(n - 1))
                continue;

            // walk forward until we hit a gap
            var length = 1;
            while (hashSet.Contains(n + length))
                length++;
            max = Math.Max(max, length);
        }
        return max;
    }
}
