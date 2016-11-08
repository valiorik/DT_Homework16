using System.Collections.Generic;
using DT_Homework16.Data.Contracts;

namespace DT_Homework16.Data
{
    public interface IItemsSource
    {
        IEnumerable<Item> GetAllItems();
    }
}
