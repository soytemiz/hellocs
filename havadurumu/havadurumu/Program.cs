using System.Xml.Linq;

string api = "c047a1683afe2cba24c742f581821ae0";
string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
XDocument weather= XDocument.Load(connection);
var temp= weather.Descendants("temperature").ElementAt(0).Attribute("value").Value;
var weatherstate = weather.Descendants("weather").ElementAt(0).Attribute("value").Value;
Console.Write("İstanbul için sıcaklık: " + temp + "  --- Hava Durumu: "+weatherstate);
Console.ReadLine();
