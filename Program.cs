
int[] numArrayNoDupes = [1, 2, 3, 4, 5];
int[] numArrayDupes = [1, 2, 3, 4, 1];

string cat = "cat";
string tac = "tac";

int targetNum = 5;

string[] strs = ["eat", "tea", "tan", "ate", "nat", "bat"];



Console.WriteLine(ArraysAndHashing.ContainsDuplicate(numArrayNoDupes, BigOTypes.BRUTE_FORCE));
Console.WriteLine(ArraysAndHashing.ContainsDuplicate(numArrayNoDupes, BigOTypes.BEST));
Console.WriteLine(ArraysAndHashing.ContainsDuplicate(numArrayDupes, BigOTypes.BRUTE_FORCE));
Console.WriteLine(ArraysAndHashing.ContainsDuplicate(numArrayDupes, BigOTypes.BEST));

Console.WriteLine($"The two strings are anagrams: {ArraysAndHashing.IsAnagram(cat, tac)}");
Console.WriteLine($"The two strings are anagrams: {ArraysAndHashing.IsAnagram(cat, tac + tac)}");

Console.WriteLine($"Two Sum: {ArraysAndHashing.TwoSum(numArrayNoDupes, targetNum)}");

Console.WriteLine($"Two Sum: {ArraysAndHashing.GroupAnagrams(strs)}");