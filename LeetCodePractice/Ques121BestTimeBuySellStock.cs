using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    class Ques121BestTimeBuySellStock
    {
        public static void MaxProfit()
        {
            int[] prices = { 7, 6, 4, 3, 1 };
            Console.WriteLine(MaxProfit(prices));
        }

        public static int MaxProfit(int[] prices)
        {
            if (prices == null && prices.Length < 2) return 0;

            int minVal = prices[0], maxPro = 0;

            for (int i = 1; i < prices.Length - 1; i++)
            {
                if (prices[i] < minVal)
                    minVal = prices[i];
                else
                    maxPro = Math.Max(prices[i] - minVal, minVal);
            }

            return maxPro;
        }

        public int MaxProfit1(int[] prices)
        {
            int minValue = int.MaxValue, maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minValue)
                {
                    minValue = prices[i];
                }
                else if (prices[i] - minValue > maxProfit)
                {
                    maxProfit = prices[i] - minValue;
                }
            }
            return maxProfit;
        }
    }
}
