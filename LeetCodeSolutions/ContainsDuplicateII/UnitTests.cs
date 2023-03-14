using Xunit;

namespace LeetCodeSolutions.ContainsDuplicateII;

public class UnitTests
{
    [Theory]
    [InlineData(new[] {1, 2, 3, 1}, 3, true)]
    [InlineData(new[] { 1, 0, 1, 1 }, 1, true)]
    [InlineData(new[] { 1, 2, 3, 1, 2, 3 }, 2, false)]
    [InlineData(new[] { 1 }, 1, false)]
    public void GivenArray_ShouldFindDistinctIndices(int[] array, int k, bool expectedResult)
    {
        var solution = new Solution();
        
        Assert.Equal(expectedResult, solution.ContainsNearbyDuplicate(array, k));
    }
}