using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Weather.Repositories;

namespace Weather.Tests.RepositoryTests
{
    [TestClass]
    public class CitiesRepositoryTests
    {
        [TestMethod]
        public void Get_City_By_Id()
        {
            var repo = new CitiesRepository();
            var city = repo.GetCity(1);
            Assert.IsNotNull(city);
        }

        [TestMethod]
        public void Get_Cities_By_Country_Name()
        {
            var repo = new CitiesRepository();
            var city = repo.GetCitiesByCountryName("australia");
            Assert.IsNotNull(city);
        }

        [TestMethod]
        public void Get_Cities_By_Country_Name_All_Capitals()
        {
            var repo = new CitiesRepository();
            var city = repo.GetCitiesByCountryName("AUSTRALIA");
            Assert.IsNotNull(city);
        }
    }
}
