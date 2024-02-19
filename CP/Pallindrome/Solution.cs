public class Solution
{
    public bool IsPalindrome(int x)
    {
        int original = x;
        if (x < 0)
            return false;

        if (x >= 0 && x < 10)
            return true;

        int temp = 0;
        int rev = 0;
        while (x > 0)
        {
            temp = x % 10;
            x = x / 10;
            rev = rev * 10 + temp;
        }
        Console.WriteLine(rev);

        return rev == original;
    }

}