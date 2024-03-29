//Author: Noah Stalnaker
using Microsoft.AspNetCore.Http.HttpResults;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AsthmaAPI.Entities
{
    public class LocationRating
    {
        public int? Rating { get; set; }

        public string? Comment { get; set; }

        public DateTime? Date { get; set; }
    }
}
