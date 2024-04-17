using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AsthmaAPI.Entities

//KarsonBastugAPII
//PushTest
{
    public class InsertR
    {
        [Key]
        public int? Rating { get; set; }
        public string? Comment { get; set; }
      
        public string? City { get; set; }
    }
}
