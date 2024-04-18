
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//KarsonBastugAPI


namespace AsthmaAPI.Entities
{
    public class MaxHealthReview
    {
        public string? City { get; set; }
        public int? MaxTemp { get; set; }

        public int? Rating { get; set; }

        public string? UserComment { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }


    }
}
