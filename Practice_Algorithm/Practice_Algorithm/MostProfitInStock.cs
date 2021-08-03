using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Algorithm
{
    public class MostProfitInStock
    {
        public int MaxProfit(int[] prices)
        {
            var max_profit = 0;
            for(int i =1; i< prices.Length-1; i++)
            {
               
                if (prices[i]> prices[i - 1])
                {
                    max_profit += prices[i] - prices[i - 1];
                }
            }
            return max_profit;
        }

    }
}
