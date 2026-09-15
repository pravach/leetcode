public class Solution
{
    public IList<string> CommonChars(string[] words)
    {
        int[] common = new int[26];

        for (int i = 0; i < words[0].Length; i++)
        {
            char c = words[0][i];
            common[c - 'a']++;
        }

        for (int i = 1; i < words.Length; i++)
        {
            int[] current = new int[26];

            for (int j = 0; j < words[i].Length; j++)
            {
                char c = words[i][j];
                current[c - 'a']++;
            }

            for (int j = 0; j < 26; j++)
            {
                common[j] = Math.Min(common[j], current[j]);
            }
        }

        List<string> result = new List<string>();

        for (int i = 0; i < 26; i++)
        {
            for (int j = 0; j < common[i]; j++)
            {
                char c = (char)('a' + i);
                result.Add(c.ToString());
            }
        }

        return result;
    }
}