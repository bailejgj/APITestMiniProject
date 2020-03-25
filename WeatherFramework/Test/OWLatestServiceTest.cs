using System;
using NUnit.Framework;
using WeatherFramework.OWLatestService;
using WeatherFramework.OWLatestService.DataHandling;
using WeatherFramework.OWLatestService.HTTPManager;
using NUnit.Framework;
// different test fixture for each service class
namespace FrameworkCreation.Test
{
    [TestFixture]
    public class OWLatestWeatherTest
    {
        // Create an instance of our Fixer latest service
        private OWLatestWeatherService oWLatestWeather = new OWLatestWeatherService();

        // Our first test to check that the request was successful
        // We do not want to be adding in logic code in the test this time around
        [Test()]
        public void WebCallSuccessCheck()
        {
            // Lets check that we have success returning true, this will tell us whether we have successfully built our framework.
            //Assert that cod is functioning
            StringAssert.IsMatch("200", (string)oWLatestWeather.CheckConnection());
        }
        [Test()]
        public void CheckCity()
        {
            //Ensure that the api is returning the figures for Birmingham
            StringAssert.IsMatch("Birmingham", (string)oWLatestWeather.GetCity());
        }
        [Test()]
        public void CheckCityId()
        {
            //Double checking that the city is correct with its ID
            StringAssert.IsMatch("2655603", (string)oWLatestWeather.GetCityId());
        }
        [Test()]
        public void CheckTemp()
        {
            StringAssert.IsMatch("281.4", (string)oWLatestWeather.GetTemp());
        }
    }
}
