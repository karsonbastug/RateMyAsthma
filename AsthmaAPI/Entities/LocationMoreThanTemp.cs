using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AsthmaAPI.Entities
{
    public class LocationMoreThanTemp
    {
        public int LID { get; set; }
        public int WID { get; set; }
        public int? MaxTemp { get; set; }
        public int? MinTemp { get; set; }
        public int? AvgTemp { get; set; }
        public int? Precipitation { get; set; }
        public DateTime Date { get; set; }

    }
}