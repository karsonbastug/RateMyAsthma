//Author: Chase Baker
using Microsoft.AspNetCore.Http.HttpResults;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AsthmaAPI.Entities
{
    public class CitySeasonRating
    {
        public string? Season { get; set; }

        public int? AverageRating { get; set; }

    }
}
