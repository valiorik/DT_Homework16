using DT_Homework16.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DT_Homework16.Basket
{
    public class ShoppingBasket : IShoppingBasket
    {
        private List<BasketItem> itemsInBasket;
        private OfferManager offerManager;

        public ShoppingBasket(IEnumerable<Offer> offers)
        {
            itemsInBasket = new List<BasketItem>();
            offerManager = new OfferManager(offers);
        }

        public void AddItem(Item item)
        {
            itemsInBasket.Add(new BasketItem(item));
        }

        public double GetTotalPrice()
        {
            double total = 0.0;

            offerManager.ApplyOffersForItems(itemsInBasket);

            total = itemsInBasket.Sum(i => i.FinalPrice);
            return Math.Round(total, 2);
        }
    }
}
