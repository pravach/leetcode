public class Solution
{
    public IList<int> SelfDividingNumbers(int left, int right)
    {
        List<int> result = new List<int>();

        for (int i = left; i <= right; i++)
        {
            int num = i;
            bool isSelfDividing = true;

            while (num > 0)
            {
                int digit = num % 10;

                
                if (digit == 0)
                {
                    isSelfDividing = false;
                    break;
                }

                
                if (i % digit != 0)
                {
                    isSelfDividing = false;
                    break;
                }

                num = num / 10;
            }

            if (isSelfDividing)
            {
                result.Add(i);
            }
        }

        return result;
    }
}