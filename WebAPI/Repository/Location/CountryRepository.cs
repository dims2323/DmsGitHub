using Contracts;
using Contracts.Location;
using Entities;
using Entities.Location;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Location
{
    public class CountryRepository : ICountryRepository
    {
        public CountryRepository()
        {
        }

        //Get all Country
        public List<Country> GetCountry()
        {
            List<Country> data = (from x in DataSample.CountryData.CountryDataSample                               
                               select x).ToList();

            return data;
        }

    }
}
