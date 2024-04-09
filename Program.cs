
int[] numArrayNoDupes = [1, 2, 3, 4, 5];
int[] numArrayDupes = [1, 2, 3, 4, 1];

string cat = "cat";
string tac = "tac";

int targetNum = 5;

string[] strs = ["eat", "tea", "tan", "ate", "nat", "bat"];

BigOTypes[] allTypes = { BigOTypes.BRUTE_FORCE, BigOTypes.OKAY, BigOTypes.BEST };

// foreach (BigOTypes type in allTypes)
// {
//     Console.WriteLine(ArraysAndHashing.ContainsDuplicate(numArrayNoDupes, type));
//     Console.WriteLine(ArraysAndHashing.ContainsDuplicate(numArrayDupes, type));
// }
// Console.WriteLine();

// Console.WriteLine($"The two strings are anagrams: {ArraysAndHashing.IsAnagram(cat, tac)}");
// Console.WriteLine($"The two strings are anagrams: {ArraysAndHashing.IsAnagram(cat, tac + tac)}");

// Console.WriteLine($"Two Sum: {ArraysAndHashing.TwoSum(numArrayNoDupes, targetNum)}");

// Console.WriteLine($"Two Sum: {ArraysAndHashing.GroupAnagrams(strs)}");

Console.WriteLine(TwoPointers.ValidPalindrome("hello"));
Console.WriteLine(TwoPointers.ValidPalindrome("ra Ar"));
Console.WriteLine(TwoPointers.ValidPalindrome("h"));
