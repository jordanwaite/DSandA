using System.Collections;

public class ArraysAndHashing
{
    private static BigOTypes[] allTypes = { BigOTypes.BRUTE_FORCE, BigOTypes.OKAY, BigOTypes.BEST };

    public static void RunContainsDuplicate()
    {

        int[] numArrayNoDupes = [1, 2, 3, 4, 5];
        int[] numArrayDupes = [1, 2, 3, 4, 1];
        Console.WriteLine("-------- RUNNING CONTAINS DUPLICATES -------");
        foreach (BigOTypes type in allTypes)
        {
            Console.WriteLine(ContainsDuplicate(numArrayNoDupes, type));
            Console.WriteLine(ContainsDuplicate(numArrayDupes, type));
        }
        Console.WriteLine("------- END OF CONTAINS DUPLICATES -------");
    }

    private static bool ContainsDuplicate(int[] nums, BigOTypes bigOTypes)
    {
        switch (bigOTypes)
        {
            case BigOTypes.BRUTE_FORCE:
                Console.Write("Brute force of contains duplicate O(n^2): ");
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] == nums[j])
                            return true;
                    }
                }
                return false;

            case BigOTypes.OKAY:
                Console.Write("Okay time of contains duplicate O(log(n)): ");
                Array.Sort(nums);
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] == nums[i - 1])
                        return true;
                }
                return false;

            default:
                Console.Write("Fastest time of contains duplicate O(n): ");
                HashSet<int> set = new(nums);
                return set.Count != nums.Length;
        }
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

    public static int[]? TwoSum(int[] nums, int target)
    {

        // loop through nums, if current num - target already existed, true

        Dictionary<int, int> map = new();
        int difference;

        for (int i = 0; i < nums.Length; i++)
        {
            difference = target - nums[i];
            if (map.ContainsKey(difference))
                return [map[difference], i];
            map.Add(nums[i], i);
        }

        return null;
    }

    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var data = new Dictionary<string, List<string>>();

        foreach (var item in strs)
        {

            var str = item.ToCharArray();
            Array.Sort(str);

            if (!data.ContainsKey(new string(str)))
                data.Add(new string(str), new List<string>());

            data[new string(str)].Add(item);
        }

        var result = new List<IList<string>>();

        foreach (List<string> list in data.Values)
            result.Add(list.Cast<string>().ToList().AsReadOnly());

        return result;
    }
}