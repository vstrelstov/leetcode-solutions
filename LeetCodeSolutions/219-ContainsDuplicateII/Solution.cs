namespace LeetCodeSolutions._219_ContainsDuplicateII;

/**
 * LeetCode-219: Contains duplicate II
 * Given an integer array nums and and integer k, return true if there are two distinct indices i and j in the array
 * such that nums[i] == nums[j] and abs(i - j) <= k
 * Constraints:
 * 1 <= nums.Length <= 10^5
 * -10^5 <= nums[i] <= 10^5
 * 0 <= k <= 10^5
*/
internal class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        if (nums.Length <= k)
        {
            var set = new HashSet<int>(nums);
            return set.Count != nums.Length;
        }
        
        var window = new HashSet<int>(); // using sliding window
        int right = 0;
        while (right <= k)
        {
            window.Add(nums[right]);
            right += 1;
        }

        if (window.Count <= k)
        {
            return true;
        }

        while (right < nums.Length)
        {
            window.Remove(nums[right - k - 1]);
            window.Add(nums[right]);
            right++;
            if (window.Count <= k)
            {
                return true;
            }
        }

        return false;
    }

    public bool ContainsNearbyDuplicateMap(int[] nums, int k)
    {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(nums[i]) && (i - map[nums[i]]) <= k)
            {
                return true;
            }

            map[nums[i]] = i;
        }

        return false;
    }
}