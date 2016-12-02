using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Weather.Data
{
    public class Country
    {
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        public List<City> Cities { get; set; }
    }
}