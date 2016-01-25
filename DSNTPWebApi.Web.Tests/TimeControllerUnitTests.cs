using System;
using System.Configuration;
using System.Net.Http;
using System.Web.Http;
using DSNTPWebApi.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSNTPWebApi.Web.Tests
{
    [TestClass]
    public class TimeControllerUnitTests
    {
        [TestMethod]
        public void TestGet_AssertDayOfYearMatch()
        {
            var controller = new TimeController
            {
                Request = new HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };
            Assert.AreEqual(DateTime.UtcNow.DayOfYear, controller.Get().DayOfYear);
        }
    }
}
