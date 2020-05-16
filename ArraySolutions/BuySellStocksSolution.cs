using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySolutions
{
    public class BuySellStocksSolution
    {
        public static void maxProfit()
        {
            //int[] prices = { 3, 3, 5, 0, 0, 3, 1, 4 };
            //int[] prices = { 7, 1, 5, 3, 6, 4 };
            //int[] prices = { 100, 180, 260, 310, 40, 535, 695 };
            //int[] prices = { 23, 13, 25, 29, 33, 19, 34, 45, 65, 67 };
            int[] prices = { 4, 2, 2, 2, 4 };
            //Console.WriteLine(maxProfitBuyAndSellDay(prices));
            maxProfitBuyAndSellDay(prices);
        }

        private static void maxProfitBuyAndSellDay(int[] price)
        {
            int profit = 0, buy_day = 0, sell_day = 0; int n = price.Length;

            for (int i = 1; i < n; i++)
            {
                if (price[i] > price[i - 1])
                {
                    if (profit == 0)
                        buy_day = i - 1;
                    profit += price[i] - price[i - 1];
                    sell_day = i;
                }
                else if (profit > 0)
                {
                    sell_day = i - 1;
                    Console.WriteLine("(" + buy_day + " " + sell_day + ") ");
                    buy_day = i;
                }
                if (i == n - 1 && profit > 0)
                {
                    sell_day = i;
                    Console.WriteLine("(" + buy_day + " " + sell_day + ") ");
                }
            }

            if (profit == 0)
                Console.WriteLine("No Profit");

        }



        public static int MaxProfitNormal(int[] prices)
        {
            if (prices == null || prices.Length < 2) return 0;

            int lowPrice = prices[0], profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    profit += prices[i] - prices[i - 1];
                }
            }

            return profit;
        }

        public static int maxProfitBruteForce(int[] prices)
        {
            int maxprofit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j] > prices[i])
                    {
                        Console.WriteLine($"prices[j] :{prices[j]} - prices[i] :{ prices[i]} , currProfit :{prices[j] - prices[i]}");
                        int currProfit = prices[j] - prices[i];
                        if (currProfit > maxprofit)
                        {
                            Console.WriteLine("(" + i + " " + j + ")");
                            maxprofit = Math.Max(currProfit, maxprofit);
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            return maxprofit;
        }

        public static int maxProfit(int[] prices)
        {
            return ProfitHelperMaxProfit(prices, 0, prices.Length);
        }

        public static int ProfitHelperMaxProfit(int[] prices, int start, int end)
        {
            if (end <= start) return 0;

            int maxProfit = 0;
            for (int i = start; i < end - 1; i++)
            {
                for (int j = i + 1; j <= end - 1; j++)
                {
                    if (prices[j] > prices[i])
                    {
                        Console.WriteLine($"prices[j] :{prices[j]} - prices[i] :{ prices[i]} , currProfit :{prices[j] - prices[i]}  , maxProfit : {Math.Max(maxProfit, prices[j] - prices[i])}");
                        int currProfit = prices[j] - prices[i]
                                      + ProfitHelperMaxProfit(prices, start, i - 1)
                                      + ProfitHelperMaxProfit(prices, j + 1, end);

                        maxProfit = Math.Max(maxProfit, currProfit);
                    }
                }

                Console.WriteLine();
                Console.WriteLine();
            }

            return maxProfit;
        }
    }
}
