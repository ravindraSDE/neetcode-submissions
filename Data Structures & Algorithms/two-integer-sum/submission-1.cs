public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        if(nums.Length <= 0)
        {
            return new int[0];
        }
        int[] ans = new int[2];
       
        for(int i=0; i < nums.Length; i++)
        {
            for(int j = 0; j < nums.Length; j++)
            {
                if(i == j)
                {
                    continue;
                }
                bool result = nums[i]+nums[j] == target;
                if(result)
                {
                    ans[0]=i;
                    ans[1]=j;
                    return ans;
                }
            }
        }

        //Array.Sort(ans);
        return ans;
    }
}