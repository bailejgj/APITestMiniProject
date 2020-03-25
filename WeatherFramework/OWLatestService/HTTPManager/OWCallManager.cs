using FrameworkCreation;
using RestSharp;
// only need one of these
namespace WeatherFramework.OWLatestService.HTTPManager
{
    public class OWCallManager
    {
        private readonly IRestClient client;

        public OWCallManager()
        {
            client = new RestClient(AppConfigReader.BaseUrl);
        }

        public string GetLatestWeather()
        {
            var request = new RestRequest("/weather" + AppConfigReader.Location + AppConfigReader.ApiUrlMod + AppConfigReader.ApiKey);
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }

        //public string GetLatestMain()
        //{
        //    var request = new RestRequest("/main" + AppConfigReader.Location + AppConfigReader.ApiUrlMod + AppConfigReader.ApiKey);
        //    var response = client.Execute(request, Method.GET);
        //    return response.Content;
        //}
    }
}
