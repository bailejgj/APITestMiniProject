using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;
using WeatherFramework.OWLatestService.DataHandling;
using WeatherFramework.OWLatestService.HTTPManager;

namespace WeatherFramework.OWLatestService
{
    // make a new service class for each different FixerCallManager method call
    public class OWLatestWeatherService
    {
        // Our instance of the call manager that manages the call to the API to get the data
        public OWCallManager oWCallManager = new OWCallManager();

        // Our instance of the DTO that transforms our data into the format of our model
        public OWLatest oWLatest = new OWLatest();

        // The last set of rates retrieved
        public String liveWeather;

        // Rates converted to JObject so we manipulate later in useful methods
        public JObject json_weather;
        //public string liveMain;
        //public JObject json_Main;
        public OWLatestWeatherService()
        {
            liveWeather = oWCallManager.GetLatestWeather();
            oWLatest.DeserializeLatestWeather(liveWeather);
            json_weather = JsonConvert.DeserializeObject<JObject>(liveWeather);
        }
        //public OWLatestMain()
        //{
        //    liveMain = oWCallManager.GetLatestMain();
        //    oWLatest.DeserializeLatestMain(liveMain);
        //    json_Main = JsonConvert.DeserializeObject<JObject>(liveMain);
        //}

        public JToken CheckConnection()
        {
            return json_weather["cod"];
        }
        public JToken GetCity()
        {
            return json_weather["name"];
        }
        public JToken GetCityId()
        {
            return json_weather["id"];
        }
        public JToken GetTemp()
        {
            return json_weather["temp"];
        }
        public JToken GetPres()
        {
            return json_weather["pressure"];
        }
        public JToken GetHum()
        {
            return json_weather["humidity"];
        }

        public JToken getBase()
        {
            Console.WriteLine(json_weather["base"]);
            return json_weather["base"];
        }
    }
}
