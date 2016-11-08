using System.Collections.Generic;

namespace DT_Homework16.Data
{
    interface IOffersSource
    {
        IEnumerable<Offer> GetAllOffers();

    }
}
