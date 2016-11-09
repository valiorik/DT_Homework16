using DT_Homework16.Data.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace DT_Homework16.Basket
{
    internal class OfferManager
    {
        private IEnumerable<Offer> offers;
        
        public OfferManager(IEnumerable<Offer> offers)
        {
            this.offers = offers;
        }

        public void ApplyOffersForItems(List<BasketItem> items)
        {
            // Search for offers
            foreach (var offer in offers)
            {
                // if offer items are present in basket and enougth quantity

                while (items.Where(i => i.Item.Name == offer.TargetProduct && i.AvailableForDiscount).Count() >= offer.TargetProductQuantity)
                {
                    // Mark those items as used for a discount
                    for (int index = 0; index < offer.TargetProductQuantity; index++)
                    {
                        items.First(i => i.Item.Name == offer.TargetProduct && i.AvailableForDiscount).MarkAsUsedForOffer();
                    }

                    ApplyDiscount(items, offer.Discounts);
                }
            }
        }

        private void ApplyDiscount(List<BasketItem> items, IEnumerable<Discount> discounts)
        {
            // Apply discounts from the offer
            foreach (var discount in discounts)
            {
                // Look for item in basket
                var availableItemForDiscount = items.FirstOrDefault(i => i.AvailableForDiscount && i.Item.Name == discount.DiscountedProduct);

                if (availableItemForDiscount != null)
                {
                    // If item was found apply discount to it
                    availableItemForDiscount.ApplyDiscount(discount.DiscountPercentage);
                }
            }
        }
    }
}
