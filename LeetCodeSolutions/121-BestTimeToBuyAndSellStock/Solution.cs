namespace LeetCodeSolutions._121_BestTimeToBuyAndSellStock;

/*
 * LeetCode-121: Best way to buy and sell stock
 * 
 * You are given an array prices where prices[i] is the price of a given stock on the ith day.
 * You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
 * Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
 */

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var mins = new int[prices.Length];
        var maxs = new int[prices.Length];

        mins[0] = prices[0];
        for (int i = 1; i < prices.Length; i++)
        {
            mins[i] = Math.Min(mins[i - 1], prices[i]);
        }

        maxs[^1] = prices[^1]; // index from end expression
        for (int i = maxs.Length - 2; i >= 0; i--)
        {
            maxs[i] = Math.Max(maxs[i + 1], prices[i]);
        }

        var maxDiff = maxs[0] - mins[0];
        for (int i = 1; i < prices.Length; i++)
        {
            maxDiff = Math.Max(maxDiff, maxs[i] - mins[i]);
        }

        return maxDiff;
    }

    public int MaxProfit2(int[] prices)
    {
        var min = prices[0];
        var maxProfit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            var localProfit = prices[i] - min;
            maxProfit = Math.Max(maxProfit, localProfit);
            min = Math.Min(min, prices[i]);
        }

        return maxProfit;
    }
}