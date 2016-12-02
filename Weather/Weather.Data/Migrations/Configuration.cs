namespace Weather.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Weather.Data.WeatherInfoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Weather.Data.WeatherInfoContext>());
        }

        protected override void Seed(Weather.Data.WeatherInfoContext infoContext)
        {


            infoContext.Countries.AddOrUpdate(new Country { Id = 1, Name = "Australia" });
            infoContext.Countries.AddOrUpdate(new Country { Id = 2, Name = "Canada" });

            infoContext.Cities.AddOrUpdate(x=> x.Id,
                new City
                {
                    Id = 1,
                    Name = "Sydney",
                    Time = "14:15",
                    Visibility = "Clear",
                    Temperature = "34 C",
                    Wind = "Mild 15 KMPH",
                    SkyConditions = "Mostly sunny with some clouds",
                    Pressure = "Low",
                    DewPoint = "32 C",
                    Location = "NSW",
                    RelativeHumidity = "22 %",
                    CountryId = 1
                },
                new City
                {
                    Id = 2,
                    Name = "Melbourne",
                    Time = "14:15",
                    Visibility = "Clear",
                    Temperature = "28 C",
                    Wind = "Mild 33 KMPH",
                    SkyConditions = "Mostly cloudy",
                    Pressure = "High",
                    DewPoint = "27 C",
                    Location = "VIC",
                    RelativeHumidity = "33 %",
                    CountryId = 1
                });

          
            infoContext.Cities.AddOrUpdate(x=> x.Id,
                new City
            {
                Id = 3,
                Name = "Ottawa",
                Time = "14:15",
                Visibility = "Foggy",
                Temperature = "-15 C",
                Wind = "Mild 11 KMPH",
                SkyConditions = "Snowing",
                Pressure = "High",
                DewPoint = "-12 C",
                Location = "Ontario",
                RelativeHumidity = "0 %",
                CountryId = 2
            },
            new City
            {
                Id = 4,
                Name = "Toronto",
                Time = "16:15",
                Visibility = "Foggy",
                Temperature = "-18 C",
                Wind = "Mild 12 KMPH",
                SkyConditions = "Snowing",
                Pressure = "High",
                DewPoint = "-13 C",
                Location = "Ontario",
                RelativeHumidity = "0 %",
                CountryId = 2
            });


        }
    }
}
