using DT_Homework16.Data.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace DT_Homework16.Basket
{
    public class ShoppingBasket : IShoppingBasket
    {
        List<Item> itemsInBasket;
        IEnumerable<Offer> offers;

        public ShoppingBasket(IEnumerable<Offer> offers)
        {
            itemsInBasket = new List<Item>();
            this.offers = offers;
        }

        public void AddItem(Item item)
        {
            itemsInBasket.Add(item);
        }

        public double GetTotalPrice()
        {
            return itemsInBasket.Sum(i => i.Price);
        }
    }
}
