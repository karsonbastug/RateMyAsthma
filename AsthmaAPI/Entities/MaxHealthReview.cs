
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//KarsonBastugAPI


namespace AsthmaAPI.Entities
{
    public class MaxHealthReview
    {
        
  
        public int? Rating { get; set; }

        public string? Comment { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }


    }
}
