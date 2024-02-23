using System.ComponentModel.DataAnnotations.Schema;

namespace WebApis.Models;

[Table("WeatherForecast")]
 public class WeatherForecast
{
    public DateTime Date { get; set; }
    public int TemperatureC { get; set; }
    public string Summary { get; set; }
    public int TemperatureF { get; set; }
}