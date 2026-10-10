public class Solution {
    public bool hasDuplicate(int[] nums) {
        bool isDuplicate = false;
        HashSet<int> resp = new HashSet<int>();
        foreach(int num in nums)
        {
            resp.Add(num);
        }

        if(resp.Count() != nums.Count())
        {
            isDuplicate = true;
        }

        return isDuplicate;
    }
}