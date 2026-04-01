public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var groups = new Dictionary<string, List<string>>();

        foreach (var str in strs) {
            var key = String.Concat(str.OrderBy(c => c));

            if (!groups.ContainsKey(key))
            {
                // Need to add the key
                groups[key] = new List<string>();
            }

            // e.g. "aet" => [eat, tea]
            groups[key].Add(str);
        }

        return groups.Values.ToList();
    }
}
