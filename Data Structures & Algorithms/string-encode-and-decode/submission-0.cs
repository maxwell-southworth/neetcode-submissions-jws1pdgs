public class Solution {

    public string Encode(IList<string> strs) {
        // ["neet", "code"] => 4|neet4|code|
        var stringBuilder = new StringBuilder();
        foreach (var str in strs)
        {
            stringBuilder.Append(str.Length);
            stringBuilder.Append("|");
            stringBuilder.Append(str);
        }
        return stringBuilder.ToString();
    }

    public List<string> Decode(string s) {
        var list = new List<string>();
        int i = 0;

        while (i < s.Length) {
            int pipeIndex = s.IndexOf('|', i);           // find the next pipe from position i
            int length = int.Parse(s.Substring(i, pipeIndex - i)); // extract length as substring, parse it
            int start = pipeIndex + 1;                   // content starts right after the pipe
            list.Add(s.Substring(start, length));        // grab exactly 'length' characters
            i = start + length;                          // jump i to the start of the next token
        }

        return list;
    }
}
