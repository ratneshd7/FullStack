using System.Collections.Generic;
using System.Text;
class Program
{
    public static void Main(string[] args)
    {
        string str = "Ratnesh";
        Console.WriteLine("Enter string value");
        string input = Console.ReadLine();
        Console.WriteLine("Enter Target");
        int target = int.Parse(Console.ReadLine());
        string[] inputValues = input.Split();
        int[] array = Array.ConvertAll(inputValues, int.Parse);
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        var indices = TwoSumwithDict(array, target);
        foreach (var item in indices)
        {
            System.Console.WriteLine(item);
        }
    }
    static int[] TwoSumwithDict(int[] nums, int target)
    {
        Dictionary<int, int> indicesDict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var check = target - nums[i];
            if (indicesDict.ContainsKey(check))
            {
                return new int[] { indicesDict[check], i };
            }
            indicesDict[nums[i]] = i;
        }
        return new[] { 0, 0 };
    }
    public static int[] TwoSum(int[] nums, int target)
    {
        int[] indices = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    indices[0] = i;
                    indices[1] = j;
                    return indices;
                }
            }
        }
        return indices;
    }
}