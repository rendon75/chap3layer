using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASPPatterns.Chap3.Layered.Model
{
    public class NullDiscountStrategy : IDiscountStrategy 
    {
        public decimal ApplyExtraDiscountStrategy(decimal originalSalePrice)
        {
            return originalSalePrice;
        }
    }
}
