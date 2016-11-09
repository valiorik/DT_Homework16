using DT_Homework16.Data.Contracts;

namespace DT_Homework16.Basket
{
    class BasketDiscount
    {
        public string DiscountedProduct { get; private set; }
        public double DiscountPercentage { get; private set; }
        public int TimesMensioned { get; private set; }

        public BasketDiscount(Discount d)
        {
            DiscountedProduct = d.DiscountedProduct;
            DiscountPercentage = d.DiscountPercentage;
        }

        public void IncreaseNuber()
        {
            TimesMensioned++;
        }
    }
}
