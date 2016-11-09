using System;
using DT_Homework16.Data.Contracts;

namespace DT_Homework16.Basket
{
    public class BasketItem
    {
        public Item Item { get; private set; }
        public double FinalPrice { get; private set; }
        public bool AvailableForDiscount { get; private set; }

        public BasketItem(Item item)
        {
            Item = item;
            FinalPrice = item.Price;
            AvailableForDiscount = true;
        }

        internal void MarkAsUsedForOffer()
        {
            AvailableForDiscount = false;
        }

        internal void ApplyDiscount(double discount)
        {
            FinalPrice = Math.Round(Item.Price * discount, 2);
            AvailableForDiscount = false;
        }
    }
}
