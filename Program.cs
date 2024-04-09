
int[] numArrayNoDupes = [1, 2, 3, 4, 5];
int[] numArrayDupes = [1, 2, 3, 4, 1];

string cat = "cat";
string tac = "tac";

int targetNum = 5;

string[] strs = ["eat","tea","tan","ate","nat","bat"];



ArraysAndHashing.ContainsDuplicate(numArrayNoDupes, "brute");
Console.WriteLine($"The int array contains duplicate numbers: {ArraysAndHashing.ContainsDuplicate(numArrayDupes)}");

Console.WriteLine($"The two strings are anagrams: {ArraysAndHashing.IsAnagram(cat, tac)}");
Console.WriteLine($"The two strings are anagrams: {ArraysAndHashing.IsAnagram(cat, tac + tac)}");

Console.WriteLine($"Two Sum: {ArraysAndHashing.TwoSum(numArrayNoDupes, targetNum)}");

Console.WriteLine($"Two Sum: {ArraysAndHashing.GroupAnagrams(strs)}");