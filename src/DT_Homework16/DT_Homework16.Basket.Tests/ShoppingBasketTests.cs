using DT_Homework16.Data;
using DT_Homework16.Data.Contracts;
using NUnit.Framework;
using System.Linq;

namespace DT_Homework16.Basket.Tests
{
    [TestFixture]
    public class ShoppingBasketTests
    {
        private Item bread;
        private Item milk;
        private Item butter;

        [SetUp]
        public void setUp()
        {
            var dataStore = new StaticItemsSource();
            var allItems = dataStore.GetAllItems();

            bread = allItems.Single(i => i.Name == "Bread");
            milk = allItems.Single(i => i.Name == "Milk");
            butter = allItems.Single(i => i.Name == "Butter");
        }

        // Given the basket has 1 bread, 1 butter and 1 milk when I total the basket then the total
        // should be £2.95
        [Test]
        public void BasketHas1Bread1ButterAnd1Milk()
        {
            IShoppingBasket basket = new ShoppingBasket();

            basket.AddItem(bread);
            basket.AddItem(butter);
            basket.AddItem(milk);

            var total = basket.GetTotalPrice();

            Assert.That(total, Is.EqualTo(2.95));
        }

        // Given the basket has 2 butter and 2 bread when I total the basket then the total should be
        // £3.10
        [Test]
        public void BasketHas2ButterAnd2Bread()
        {
            IShoppingBasket basket = new ShoppingBasket();

            basket.AddItem(butter);
            basket.AddItem(butter);
            basket.AddItem(bread);

            var total = basket.GetTotalPrice();

            Assert.That(total, Is.EqualTo(3.10));
        }

        // Given the basket has 4 milk when I total the basket then the total should be £3.45
        [Test]
        public void BasketHas4Milk()
        {
            IShoppingBasket basket = new ShoppingBasket();

            basket.AddItem(milk);
            basket.AddItem(milk);
            basket.AddItem(milk);
            basket.AddItem(milk);

            var total = basket.GetTotalPrice();

            Assert.That(total, Is.EqualTo(3.45));
        }

        // Given the basket has 2 butter, 1 bread and 8 milk when I total the basket then the total
        // should be £9.00
        [Test]
        public void BasketHas2Butter1BreadAnd8Milk()
        {
            IShoppingBasket basket = new ShoppingBasket();

            basket.AddItem(butter);
            basket.AddItem(butter);
            basket.AddItem(bread);
            basket.AddItem(milk);
            basket.AddItem(milk);
            basket.AddItem(milk);
            basket.AddItem(milk);
            basket.AddItem(milk);
            basket.AddItem(milk);
            basket.AddItem(milk);
            basket.AddItem(milk);

            var total = basket.GetTotalPrice();

            Assert.That(total, Is.EqualTo(9.00));
        }
    }
}
