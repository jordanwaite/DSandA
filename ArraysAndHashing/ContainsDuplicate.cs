public class ArraysAndHashing
{
    public static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new(nums);

        return set.Count != nums.Length;
    }

    public static bool IsAnagram(string s, string t)
    {


        return false;
    }
}