using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AsthmaAPI.Entities
{
    public class Location
    {
        [Key]
        public int LID { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Address { get; set; }

        public string ZipCode { get; set; }
    }
}
