using Contracts;
using Contracts.Location;
using Entities;
using Entities.Location;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Location
{
    public class CityRepository : ICityRepository
    {
        public CityRepository()
        {            
        }

        //Get City By Country ID
        public List<City> GetCityBy(string countryid)
        {
            List<City> data = (from x in DataSample.CityData.CityDataSample 
                               where x.Country_id == countryid 
                               select x).ToList();

            return data;
        }
    }
}
