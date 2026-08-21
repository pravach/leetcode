public class Solution
{
    public int[] RelativeSortArray(int[] arr1, int[] arr2)
    {
        int[] arr3 = new int[arr1.Length];
        bool[] used = new bool[arr1.Length];

        int index = 0;

        
        for (int i = 0; i < arr2.Length; i++)
        {
            for (int j = 0; j < arr1.Length; j++)
            {
                if (!used[j] && arr2[i] == arr1[j])
                {
                    arr3[index] = arr1[j];
                    index++;
                    used[j] = true;
                }
            }
        }

        
        int[] remaining = new int[arr1.Length - index];
        int k = 0;

        for (int i = 0; i < arr1.Length; i++)
        {
            if (!used[i])
            {
                remaining[k] = arr1[i];
                k++;
            }
        }

       
        Array.Sort(remaining);

        
        for (int i = 0; i < remaining.Length; i++)
        {
            arr3[index] = remaining[i];
            index++;
        }

        return arr3;
    }
}