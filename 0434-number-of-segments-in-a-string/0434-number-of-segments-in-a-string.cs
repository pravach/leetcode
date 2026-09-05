public class Solution
{
    public int CountSegments(string s)
    {
        int count = 0;

        for (int i = 0; i < s.Length; i++)
        {
           
            if (s[i] != ' ' && (i == 0 || s[i - 1] == ' '))
            {
                count++;
            }
        }

        return count;
    }
}