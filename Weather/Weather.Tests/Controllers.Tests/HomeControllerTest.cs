using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Weather;
using Weather.Controllers;

namespace Weather.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index(redirect: false) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }

        //[TestMethod]
        //public void Index_Redirect()
        //{
        //    // Arrange
        //    HomeController controller = new HomeController();

        //    // Act
        //    var result = controller.Index(redirect: true) as RedirectResult;

        //    // Assert
        //    Assert.IsNotNull(result);
        //}
    }
}
