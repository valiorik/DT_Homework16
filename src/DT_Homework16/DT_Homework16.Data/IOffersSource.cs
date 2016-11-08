using DT_Homework16.Data.Contracts;
using System.Collections.Generic;

namespace DT_Homework16.Data
{
    public interface IOffersSource
    {
        IEnumerable<Offer> GetAllOffers();
    }
}
