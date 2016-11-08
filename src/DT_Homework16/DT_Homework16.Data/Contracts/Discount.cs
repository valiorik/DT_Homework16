using System;

namespace DT_Homework16.Data.Contracts
{
    public class Discount
    {
        public Guid Id { get; private set; }
        public string DiscountedProduct { get; set; }
        public double DiscountPercentage { get; set; }

        public Discount()
        {
            Id = Guid.NewGuid();
        }
    }
}
