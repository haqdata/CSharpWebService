using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceSample3
{
    /// <summary>
    /// Summary description for SampleService3
    /// </summary>
    [WebService(Namespace = "http://www.wrox.com/BeginningCSharp/2010")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
         
        public class SampleService3 : System.Web.Services.WebService
    {

       /*  [WebMethod]
        public string ReverseString(string message)
        {
            return new string(message.Reverse().ToArray());
        }*/

        [WebMethod]

        public GetWeatherResponse GetWeather(GetWeatherRequest req)

        {

            var resp = new GetWeatherResponse();

            var r = new Random();

            int celsius = r.Next(-20, 50);

            if (req.TemperatureType == TemperatureType.Celsius)

                resp.Temperature = celsius;

            else

                resp.Temperature = (212 - 32) / 100 * celsius + 32;

            if (req.City == "Redmond")

                resp.Condition = TemperatureCondition.Rainy;

            else

                resp.Condition = (TemperatureCondition)r.Next(0, 3);

            return resp;

        }
    }

}
