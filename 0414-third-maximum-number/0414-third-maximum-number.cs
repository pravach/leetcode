public class Solution {
    public int ThirdMax(int[] nums) {
    
        int[] arr = nums.Distinct()
               .OrderByDescending(x => x)
               .ToArray();
        if(arr.Length>=3){
            return arr[2];
        }
        else{
            return arr[0];
        }
            



        }
        
    }
