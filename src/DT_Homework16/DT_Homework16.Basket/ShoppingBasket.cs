using DT_Homework16.Data.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace DT_Homework16.Basket
{
    public class ShoppingBasket : IShoppingBasket
    {
        List<BasketItem> itemsInBasket;

        public ShoppingBasket()
        {
            itemsInBasket = new List<BasketItem>();
        }

        public void AddItem(Item item)
        {
            var basketItem = new BasketItem(item);
            itemsInBasket.Add(basketItem);
        }

        public double GetTotalPrice()
        {
            return itemsInBasket.Sum(i => i.Item.Price);
        }
    }
}
