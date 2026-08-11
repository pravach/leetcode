public class Solution
{
    public void ReverseString(char[] s)
    {
        int j = s.Length - 1;

        for (int i = 0; i < s.Length / 2; i++)
        {
            char temp = s[i];

            s[i] = s[j];

            s[j] = temp;

            j--;
        }
    }
}