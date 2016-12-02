using System.Data.Entity;

namespace Weather.Data
{
    public class WeatherInfoContext : DbContext
    {
        public WeatherInfoContext()
            : base("WeatherInfo"){}

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
