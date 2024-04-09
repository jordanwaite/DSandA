public class TwoPointers
{
    public static bool ValidPalindrome(string s)
    {
        string asciiOnly = new string(s.Where(c =>
            (c >= '0' && c <= '9') ||
            (c >= 'A' && c <= 'Z') ||
            (c >= 'a' && c <= 'z')).ToArray());


        if (asciiOnly.Length == 1)
            return true;
        asciiOnly = asciiOnly.ToLower();
        int j = asciiOnly.Length - 1;
        for (int i = 0; i <= j; i++, j--)
        {
            if (asciiOnly[i] != asciiOnly[j])
                return false;
        }
        return true;
    }
}