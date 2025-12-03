/**
 * 121. Best Time to Buy and Sell Stock
 * https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
 */

 /**
  * Solution
  * Keep track of lowest price and max profit, update on each iteration through the array.
  */
int maxProfit(int* prices, int pricesSize) {
    int lowest_price = prices[0];
    int max_profit = 0;

    for (int i = 1; i < pricesSize; i++) {
        if (prices[i] < lowest_price)
            lowest_price = prices[i];
            
        int profit = prices[i] - lowest_price;

        if (profit > max_profit)
            max_profit = profit;
    }

    return max_profit;
}