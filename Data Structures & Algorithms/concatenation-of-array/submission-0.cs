public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int size = nums.Length;
        int[] resp = new int[size * 2];
        for(int i = 0; i< nums.Length; i++)
            {
               resp[i]= nums[i];
               resp[i+size] = nums[i];
            }
        return resp;
    }
}