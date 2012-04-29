using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASPPatterns.Chap3.Layered.Model
{
    public class TradeDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyExtraDiscountStrategy(decimal originalSalePrice)
        {
            decimal price = originalSalePrice;

            price = price * 0.95M;

            return price;
        }
    }
}
