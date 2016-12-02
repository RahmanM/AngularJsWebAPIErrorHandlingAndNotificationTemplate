using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Weather.Api;
using Weather.Data;
using Weather.Repositories;

namespace Weather.Tests.Api.Tests
{
    [TestClass]
    public class CitiesControllrsTests
    {
        [TestMethod]
        public void GetCitiesByCountryName_Should_Resolve_Dependency()
        {
            var mockedRepo = new Mock<ICitiesRepository>();
            var expected = new List<City>()
            {
                new City() {Id = 1}
            };
            mockedRepo.Setup(f => f.GetCitiesByCountryName(It.IsAny<string>())).Returns(expected.AsQueryable);

            var controller = new CitiesController(mockedRepo.Object);

            var result = controller.GetCitiesByCountryName("SomeCountry");
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());

        }

        [TestMethod]
        public void GetCity_Should_Resolve_Dependency_And_Return_City()
        {
            var mockedRepo = new Mock<ICitiesRepository>();
            var city = new City() {Id = 1, Name = "Sydney"};
            mockedRepo.Setup(f => f.GetCity(It.IsAny<int>())).Returns(city);

            var controller = new CitiesController(mockedRepo.Object);

            var actionResult = controller.GetCity(111);
            var result = actionResult as OkNegotiatedContentResult<City>;
            Assert.IsNotNull(result);

            var resultCity = result.Content as City;
            Assert.IsTrue(resultCity.Name == "Sydney");

        }

        [TestMethod]
        public void GetCity_Should_Resolve_Dependency_And_Return_Not_Found()
        {
            var mockedRepo = new Mock<ICitiesRepository>();
            mockedRepo.Setup(f => f.GetCity(It.IsAny<int>())).Returns((City) null);

            var controller = new CitiesController(mockedRepo.Object);

            var actionResult = controller.GetCity(111);
            var result = actionResult as NotFoundResult;
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));

        }
    }
}
