using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AsthmaAPI.Entities

//KarsonBastugAPII
//PushTest
{
    public class InsertR
    {
        [Key]

        public string? Comment { get; set; }
        public int? Rating { get; set; }
        public string? City { get; set; }
    }
}
