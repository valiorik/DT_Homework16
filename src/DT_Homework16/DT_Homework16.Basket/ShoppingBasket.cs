using DT_Homework16.Data.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace DT_Homework16.Basket
{
    public class ShoppingBasket : IShoppingBasket
    {
        List<Item> itemsInBasket;

        public ShoppingBasket()
        {
            itemsInBasket = new List<Item>();
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
