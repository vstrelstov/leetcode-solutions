using Xunit;

namespace LeetCodeSolutions._121_BestTimeToBuyAndSellStock;

public class UnitTests
{
    [Theory]
    [InlineData(new[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [InlineData(new[] { 7, 6, 4, 3, 1 }, 0)]
    public void GivenPrices_ShouldReturnProfit(int[] prices, int expectedResult)
    {
        var solution = new Solution();
        
        Assert.Equal(expectedResult, solution.MaxProfit(prices));
    }
}