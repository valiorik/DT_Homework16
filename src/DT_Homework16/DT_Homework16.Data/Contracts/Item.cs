using System;

namespace DT_Homework16.Data.Contracts
{
    abstract public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
