using System.ComponentModel.DataAnnotations;

namespace Weather.Data
{
    public class City
    {
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Location { get; set; }
        [StringLength(20)]
        public string Time { get; set; }
        [StringLength(20)]
        public string Wind { get; set; }
        [StringLength(20)]
        public string Visibility { get; set; }
        [StringLength(150)]
        public string SkyConditions { get; set; }
        [StringLength(25)]
        public string Temperature { get; set; }
        [StringLength(20)]
        public string DewPoint { get; set; }
        [StringLength(20)]
        public string RelativeHumidity { get; set; }
        [StringLength(20)]
        public string Pressure { get; set; }

        public int CountryId { get; set; }
    }
}