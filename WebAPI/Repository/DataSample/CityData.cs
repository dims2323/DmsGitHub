using Entities.Location;
using System.Collections.Generic;

namespace Repository.DataSample
{
    public class CityData
    {
        public static readonly List<City> CityDataSample = new List<City>()
        {
            new City() { 
                City_id = "101", 
                City_name = "Brisbane",
                Country_id = "1"},
            new City() {
                City_id = "102",
                City_name = "Canberra",
                Country_id = "1"},
            new City() {
                City_id = "103",
                City_name = "Perth",
                Country_id = "1"},
            new City() {
                City_id = "104",
                City_name = "Sydney",
                Country_id = "1"},

            new City() {
                City_id = "201",
                City_name = "Aceh",
                Country_id = "2"},
            new City() {
                City_id = "202",
                City_name = "Bali",
                Country_id = "2"},
            new City() {
                City_id = "203",
                City_name = "Bandung",
                Country_id = "2"},
            new City() {
                City_id = "204",
                City_name = "Jakarta",
                Country_id = "2"},
        };

    }
}
