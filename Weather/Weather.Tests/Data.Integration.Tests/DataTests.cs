using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Weather.Data;

namespace Weather.Tests
{
    [TestClass]
    public class DataTests
    {
        [TestMethod]
        public void ReadCountries_Expect_Two_Countries()
        {
            using (var context = new WeatherInfoContext())
            {
                var countries = from f in context.Countries
                                select f;

                Assert.IsTrue(countries.Any());
            }
        }

        [TestMethod]
        public void ReadCities_Expect_Two_Cities()
        {
            using (var context = new WeatherInfoContext())
            {
                var cities = from f in context.Cities
                                where f.CountryId == 1
                                select f;

                Assert.IsTrue(cities.Any());
            }
        }

        [TestMethod]
        public void Get_Cities_By_Country_Name()
        {
            using (var context = new WeatherInfoContext())
            {
                var cities =
                    from c in context.Cities
                    join cntry in context.Countries
                    on c.CountryId equals cntry.Id
                    where cntry.Name == "australia"
                    select c;

                Assert.IsTrue(cities.Any());
            }
        }
    }
}
