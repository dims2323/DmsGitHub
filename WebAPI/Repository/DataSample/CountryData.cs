using Entities.Location;
using System.Collections.Generic;

namespace Repository.DataSample
{
    public class CountryData
    {
        public static readonly List<Country> CountryDataSample = new List<Country>()
        {
            new Country() { Country_id = "1", Country_name = "Australia"},
            new Country() { Country_id = "2", Country_name = "Indonesia"},
            new Country() { Country_id = "3", Country_name = "Singapore"},
            new Country() { Country_id = "4", Country_name = "Malaysia"},
            new Country() { Country_id = "5", Country_name = "Thailand"},           
            new Country() { Country_id = "6", Country_name = "Brunei Darrusalam"}
        };

    }
}
