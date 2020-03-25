using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherFramework.OWLatestService.DataHandling
{
    public class OWLatest
    {
        // The class is the model of data.
        public OWLatestModel LatestWeather { get; set; }
        public OWLatestModel LatestMain { get; set; }

        // Method that creates the above object following passing in the response from the API
        public void DeserializeLatestWeather(string LatestWeatherResponse)
        {
            LatestWeather = JsonConvert.DeserializeObject<OWLatestModel>(LatestWeatherResponse);
        }
        public void DeserializeLatestMain(string LatestMainResponse)
        {
            LatestMain = JsonConvert.DeserializeObject<OWLatestModel>(LatestMainResponse);
        }
    }
}