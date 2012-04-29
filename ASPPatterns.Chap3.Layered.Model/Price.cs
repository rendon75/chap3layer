using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASPPatterns.Chap3.Layered.Model
{
    public class Price
    {
        private IDiscountStrategy _discountStategy = new NullDiscountStrategy();
        private decimal _rrp;
        private decimal _sellingPrice;

        public Price(decimal RRP, decimal sellingPrice)
        {
            _rrp = RRP;
            _sellingPrice = sellingPrice;
        }

        public void SetDiscountStrategyTo(IDiscountStrategy discountStrategy)
        {
            _discountStategy = discountStrategy;
        }

        public decimal SellingPrice
        {
            get { return _discountStategy.ApplyExtraDiscountStrategy(_sellingPrice); }
        }

        public decimal RRP
        {
            get { return _rrp; }
        }

        public decimal Discount
        {
            get
            {
                if (RRP > SellingPrice)
                    return (RRP - SellingPrice);
                else
                    return 0;
            }
        }

        public decimal Savings
        {
            get
            {
                if (RRP > SellingPrice)
                    return 1 - (SellingPrice / RRP);
                else
                    return 0;
            }
        }
    }
}
