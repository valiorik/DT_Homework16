using DT_Homework16.Data.Contracts;

namespace DT_Homework16.Basket
{
    public class BasketItem
    {
        public Item Item { get; private set; }
        public bool UsedForOffer { get; set; }
        public bool AddedAsOffer { get; set; }

        public BasketItem(Item item, bool addedAsOffer)
        {
            Item = item;
            UsedForOffer = false;
            AddedAsOffer = addedAsOffer;
        }
    }
}
