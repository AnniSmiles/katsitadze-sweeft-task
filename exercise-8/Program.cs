// See https://aka.ms/new-console-template for more information
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;

Uri uri = new Uri("https://restcountries.com/v3.1/all");

var client = new HttpClient();

client.BaseAddress = uri;



var response = await client.GetStringAsync(uri);

JArray array = JArray.Parse(response);
string population = string.Empty;
string area = string.Empty;
string subregion = string.Empty;
string langtd = string.Empty;
string region = string.Empty;

JToken jToken;
string countryname = String.Empty;
foreach (JObject obj in array.Children<JObject>())
{
    foreach (JProperty singleProp in obj.Properties())
    {
        string name = singleProp.Name;
        string value = singleProp.Value.ToString();
        if(name == "name")
        {
            JObject myobj = JObject.Parse(value);
            jToken = myobj.GetValue("common");
            jToken.ToString().Replace('{',' ');
            jToken.ToString().Replace('}', ' ');
            countryname = jToken.ToString().Trim();


        }
        else if(name == "population")
        {
            population = value;
        }else if(name == "subregion")
        {
            subregion = value;
        }else if(name == "area")
        {
            area = value;
        }else if(name == "latlng")
        {
            langtd = value;
        }else if(name == "region")
        {
            region = value;
        }
              
    }
    var ct = Country.CreateCountry(countryname, region, langtd, area, subregion, population);
    string text = JsonConvert.SerializeObject(ct, Formatting.Indented);
    File.WriteAllText(String.Format("C:\\Users\\cutea\\source\\repos\\katsitadze-sweeft-task\\countries\\{0}.txt", ct.Name), text);
}

class Country
{
    public string Name { get; set; }
    [JsonProperty]
    public string Region { get; set; }
    [JsonProperty]
    public string Latlng { get; set; }
    [JsonProperty]
    public string Area { get; set; }
    [JsonProperty]
    public string SubRegion { get; set; }
    [JsonProperty]
    public string Population { get; set; }

    public static Country CreateCountry(string name,string region,string latlng,string area,string subreg,string population)
    {
        return new Country { Name = name,Region = region, Latlng = latlng, Area = area, Population = population, SubRegion = subreg};
    }
}









