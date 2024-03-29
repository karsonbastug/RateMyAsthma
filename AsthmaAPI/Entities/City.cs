using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AsthmaAPI.Entities

//KarsonBastugAPII

{
    public class City
    {
        [Key]

        public int? MaxTemp {  get; set; }
        public int? AvgTemp {  get; set; }
        public int? MinTemp { get; set; }
        public int? Rating { get; set; }
        public DateTime? Date { get; set; }
    }
}
