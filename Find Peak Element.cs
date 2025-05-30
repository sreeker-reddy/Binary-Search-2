/*
  Time complexity: O(log n)
  Space complexity: O(1)

  Code ran successfully on Leetcode: Yes

  Approach: The element is bigger than it's immediate neighbours. For mid we proceed towards the half which is bigger than mid.
*/

public class Solution {
    public int FindPeakElement(int[] nums) {
        int low = 0;
        int high = nums.Length-1;

        while(low<=high)
        {
            int mid = low+(high-low)/2;
            if((mid==0 || nums[mid]>nums[mid-1]) && (mid==nums.Length-1 || nums[mid]>nums[mid+1]))
            {
                return mid;
            }
            else
            {
                if(mid>0 && nums[mid]<nums[mid-1])
                {
                    high = mid-1;
                }
                else
                {
                    low = mid+1;
                }
            }
        }
        return -1;
    }
}
