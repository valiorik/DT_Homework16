using DT_Homework16.Data.Contracts;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace DT_Homework16.Data.Tests
{
    [TestFixture]
    class ItemsSourceTests
    {
        private IEnumerable<Item> allItems;

        [SetUp]
        public void SetUp()
        {
            var dataStore = new StaticItemsSource();
            allItems = dataStore.GetAllItems();
        }

        [Test]
        public void GetCorrectNumberOfItems()
        {
            Assert.That(allItems.Count(), Is.EqualTo(3));
        }

        [Test]
        public void MakeSureMilkButterAndBreadArePresent()
        {
            Assert.IsTrue(allItems.Any(i => i.Name == "Butter"));
            Assert.IsTrue(allItems.Any(i => i.Name == "Milk"));
            Assert.IsTrue(allItems.Any(i => i.Name == "Bread"));
        }

        [Test]
        public void MakeSureVodkaAndCigaretsAreNotPresent()
        {
            Assert.IsFalse(allItems.Any(i => i.Name == "Vodka"));
            Assert.IsFalse(allItems.Any(i => i.Name == "Cigarets"));
        }

        [Test]
        public void MakeSureDataIsNotBlanc()
        {
            foreach(var item in allItems)
            {
                Assert.IsNotNull(item.Price);
                Assert.IsNotNull(item.Id);
            }
        }
    }
}
