using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Location;

namespace Contracts.Location
{
    public interface ICityRepository
    {
        List<City> GetCityBy(string countryid);
    }
}
