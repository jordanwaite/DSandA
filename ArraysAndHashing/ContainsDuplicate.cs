public class ArraysAndHashing
{
    public static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new(nums);

        return set.Count != nums.Length;
    }

    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> map = new();

        foreach (char c in s)
        {
            if (!map.ContainsKey(c))
                map.Add(c, 0);
            map[c]++;
        }

        foreach (char c in t)
        {
            if (!map.ContainsKey(c) || map[c] == 0)
            {
                return false;
            }
            map[c]--;
        }

        return true;
    }
}