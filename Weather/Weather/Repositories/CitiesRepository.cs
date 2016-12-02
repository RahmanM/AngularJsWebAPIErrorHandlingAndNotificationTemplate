using System.Linq;
using Weather.Data;

namespace Weather.Repositories
{
    /// <summary>
    /// Repository for entity framework to return data for City
    /// </summary>
    public class CitiesRepository : ICitiesRepository
    {
        private readonly  WeatherInfoContext _Context = new WeatherInfoContext();

        public IQueryable<City> GetCitiesByCountryName(string countryName)
        {
            var cities =
                    from cty in _Context.Cities
                    join cntry in _Context.Countries
                    on cty.CountryId equals cntry.Id
                    where cntry.Name.ToLower() == countryName.ToLower()
                    select cty;

            return cities;
        }

        public City GetCity(int id)
        {
            var city = _Context.Cities.SingleOrDefault(i=> i.Id == id);
            return city;
        }
    }
}