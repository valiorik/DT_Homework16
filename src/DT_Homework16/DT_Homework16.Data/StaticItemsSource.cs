using DT_Homework16.Data.Contracts;
using System.Collections.Generic;

namespace DT_Homework16.Data
{
    public class StaticItemsSource : IItemsSource
    {
        public IEnumerable<Item> GetAllItems()
        {
            var items = new List<Item>();

            items.Add(new DairyItem { Name = "Butter", Price = 0.8 });
            items.Add(new DairyItem { Name = "Milk", Price = 1.15 });
            items.Add(new BakeryItem { Name = "Bread", Price = 1 });

            return items;
        }
    }
}
