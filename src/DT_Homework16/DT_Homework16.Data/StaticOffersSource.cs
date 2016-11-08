using System;
using System.Collections.Generic;
using DT_Homework16.Data.Contracts;

namespace DT_Homework16.Data
{
    class StaticOffersSource : IOffersSource
    {
        public IEnumerable<Offer> GetAllOffers()
        {
            var offers = new List<Offer>();

            // Should be more human-readable with batabes join...
            offers.Add(new Offer { TargetProduct = "Butter", TargetProductQuantity = 2, Discounts = new List<Discount>() { new Discount() { DiscountedProduct = "Bread", DiscountPercentage = 0.50 } } });
            offers.Add(new Offer { TargetProduct = "Milk", TargetProductQuantity = 3, Discounts = new List<Discount>() { new Discount() { DiscountedProduct = "Milk", DiscountPercentage = 0 } } });

            return offers;
        }
    }
}
