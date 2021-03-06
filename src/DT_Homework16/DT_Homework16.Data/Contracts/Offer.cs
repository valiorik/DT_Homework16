﻿using System;
using System.Collections.Generic;

namespace DT_Homework16.Data.Contracts
{
    public class Offer
    {
        public Guid Id { get; private set; }
        public string TargetProduct { get; set; }
        public uint TargetProductQuantity { get; set; }
        public IEnumerable<Discount> Discounts { get; set; }

        public Offer()
        {
            Id = Guid.NewGuid();
        }
    }
}
