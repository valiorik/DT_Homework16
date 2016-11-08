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

        [Test]
        public void BasketHas1Bread1ButterAnd1Milk()
        {
            IShoppingBasket basket = new ShoppingBasket();

            basket.AddItem(bread);
            basket.AddItem(bread);
            basket.AddItem(bread);

            var total = basket.GetTotalPrice();

            Assert.That(total, Is.EqualTo(2.95));

        }
    }
}
