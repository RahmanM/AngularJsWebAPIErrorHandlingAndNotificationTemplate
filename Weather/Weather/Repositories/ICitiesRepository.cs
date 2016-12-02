using System.Linq;
using Weather.Data;

namespace Weather.Repositories
{
    public interface ICitiesRepository
    {
        IQueryable<City> GetCitiesByCountryName(string countryName);
        City GetCity(int id);
    }
}