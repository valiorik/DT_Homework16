using DT_Homework16.Data.Contracts;
using System;
using System.Collections.Generic;

namespace DT_Homework16.Data
{
    public class StaticItemsSource : IItemsSource
    {
        public IEnumerable<Item> GetAllItems()
        {
            throw new System.Exception("not implemented");
        }
    }
}
