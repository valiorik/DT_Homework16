using DT_Homework16.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DT_Homework16.Basket
{
    public class ShoppingBasket : IShoppingBasket
    {
        List<BasketItem> itemsInBasket;
        IEnumerable<Offer> offers;

        public ShoppingBasket(IEnumerable<Offer> offers)
        {
            itemsInBasket = new List<BasketItem>();
            this.offers = offers;
        }

        public void AddItem(Item item)
        {
            itemsInBasket.Add(new BasketItem(item));
        }

        public double GetTotalPrice()
        {
            double total = 0.0;

            // Search for offers
            foreach (var offer in offers)
            {
                // if offer items are present in basket and enougth quantity

                while (itemsInBasket.Where(i => i.Item.Name == offer.TargetProduct && i.AvailableForDiscount).Count() >= offer.TargetProductQuantity)
                {
                    // Mark those items as used for a discount
                    for (int index = 0; index < offer.TargetProductQuantity; index++)
                    {
                        itemsInBasket.First(i => i.Item.Name == offer.TargetProduct && i.AvailableForDiscount).MarkAsUsedForOffer();
                    }

                    // Now apply discounts from the offer
                    foreach (var discount in offer.Discounts)
                    {
                        // Look for item in basket
                        var availableItemForDiscount = itemsInBasket.FirstOrDefault(i => i.AvailableForDiscount && i.Item.Name == discount.DiscountedProduct);
                        
                        if (availableItemForDiscount != null)
                        {
                            // If item was found apply discount to it
                            availableItemForDiscount.ApplyDiscount(discount.DiscountPercentage);
                        }
                    }
                } 
            }

            total = itemsInBasket.Sum(i => i.FinalPrice);
            return Math.Round(total, 2);
        }
    }
}
