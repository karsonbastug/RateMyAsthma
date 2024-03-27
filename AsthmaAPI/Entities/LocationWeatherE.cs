//Author: Chase Baker
using Microsoft.AspNetCore.Http.HttpResults;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AsthmaAPI.Entities
{
    public class LocationWeatherE
    {

        public int? MaxTemp { get; set; }
        public int? AvgTemp { get; set; }
        public int? MinTemp { get; set; }
        public int? Precipitation { get; set; }
    }
}
