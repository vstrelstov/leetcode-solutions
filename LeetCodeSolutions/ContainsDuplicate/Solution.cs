namespace LeetCodeSolutions.ContainsDuplicate;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        var set = new HashSet<int>();
        foreach (var number in nums)
        {
            if (set.Contains(number))
            {
                return true;
            }

            set.Add(number);
        }

        return false;
    }
}