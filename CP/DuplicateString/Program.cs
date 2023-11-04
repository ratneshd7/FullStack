// See https://aka.ms/new-console-template for more information

System.Console.WriteLine("---Count the Duplicate char---");
System.Console.WriteLine("Enter  String Value");
var testString = Console.ReadLine();
if (string.IsNullOrEmpty(testString))
{
    return;
}

Dictionary<char, int> countChar = new Dictionary<char, int>(testString.Length);

foreach (var item in testString)
{
    if (countChar.ContainsKey(item))
    {
        ++countChar[item];
        continue;
    }
    countChar.Add(item, 1);
}

foreach (var item in countChar)
{
    if (item.Value > 1)
    {
        System.Console.WriteLine(item.Key + " repeated by " + item.Value);
    }
}