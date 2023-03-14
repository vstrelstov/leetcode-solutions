using Xunit;

namespace LeetCodeSolutions.ContainsDuplicate;
/* LeetCode-217: Contains Duplicate
 * Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
 */
public class UnitTests
{
    [Theory]
    [InlineData(new[] {1, 2, 3, 1}, true)]
    [InlineData(new[] { 1, 2, 3, 4 }, false)]
    [InlineData(new[] { 1,1,1,3,3,4,3,2,4,2 }, true)]
    public void GivenArrayOfInt_ShouldReturnExpectedResult(int[] array, bool expectedResult)
    {
        var solution = new Solution();

        Assert.Equal(solution.ContainsDuplicate(array), expectedResult);
    }
}