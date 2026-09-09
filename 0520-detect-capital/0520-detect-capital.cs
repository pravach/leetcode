public class Solution {
    public bool DetectCapitalUse(string word) {
        {
        int capitalCount = 0;

        for (int i = 0; i < word.Length; i++)
        {
            if (char.IsUpper(word[i]))
            {
                capitalCount++;
            }
        }

        if (capitalCount == word.Length)
        {
            return true;
        }

        if (capitalCount == 0)
        {
            return true;
        }

        if (capitalCount == 1 && char.IsUpper(word[0]))
        {
            return true;
        }

        return false;
    }
}
}