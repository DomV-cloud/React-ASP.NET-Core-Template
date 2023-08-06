using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Car_E_shop.Models
{
    public class Car: EntityBase
    {

        [Required]
        public string ProducerName { get; set; } = string.Empty;

        [Required]
        public string CarMake { get; set; } = string.Empty;

        [Required]
        public DateTime YearOfProduction { get; set; }

        [Required]
        [JsonIgnore]
        public bool IsDeleted { get; set; }

        [Required]
        public double Price{ get; set; }

        [ForeignKey("User")]
        public int OwnerId{ get; set; }
        public User? Owner { get; set; }

        [Required]
        public string TypeOfCar { get; set; } = string.Empty;


    }

   
}
