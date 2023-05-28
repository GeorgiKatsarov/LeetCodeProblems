public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return "";
        }

        Array.Sort(strs);

        string first = strs[0];
        string last = strs[strs.Length - 1];
        int length = Math.Min(first.Length, last.Length);

        int i = 0;
        while (i < length && first[i] == last[i])
        {
            i++;
        }

        return first.Substring(0, i);
    }
}