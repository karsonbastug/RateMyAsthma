using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AsthmaAPI.Entities

//KarsonBastugAPII
//PushTest
{
    public class City2
    {
        [Key]

        public string? UserComment { get; set; }
        public string? City {  get; set; }
        public int? MaxTemp {  get; set; }
        public int? AvgTemp {  get; set; }
        public int? MinTemp { get; set; }
        public int? Rating { get; set; }
        public DateTime? Date { get; set; }
    }
}
