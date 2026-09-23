public class Solution {
    public char FindTheDifference(string s, string t)
{
    bool[] used = new bool[t.Length];

    for (int i = 0; i < s.Length; i++)
    {
        for (int j = 0; j < t.Length; j++)
        {
            if (!used[j] && s[i] == t[j])
            {
                used[j] = true;
                break;
            }
        }
    }

    for (int j = 0; j < t.Length; j++)
    {
        if (!used[j])
        {
            return t[j];
        }
    }

    return '\0';
}
}