using DT_Homework16.Data.Contracts;

namespace DT_Homework16.Basket
{
    public interface IShoppingBasket
    {
        void AddItem(Item item);
        double GetTotalPrice();
    }
}
