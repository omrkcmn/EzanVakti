using System.Net;
using Newtonsoft.Json;
using RestSharp;

namespace EzanVakti;

public class PrayTimeService
{
    public PrayTimeService()
    {
        
    }
    public async Task<PrayerTimesModel?> GetPrayerTimes()
    {
        var options = new RestClientOptions("")
        {
            MaxTimeout = -1,
        };
        var client = new RestClient(options);
        var request = new RestRequest("http://api.aladhan.com/v1/calendarByCity/2024/7?city=Pendik&country=Türkiye&method=13");
        var body = @"";
        request.AddParameter("text/plain", body,  ParameterType.RequestBody);
        RestResponse response = await client.ExecuteAsync(request);
        return null;
     }
}
