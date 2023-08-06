using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_E_shop.Models
{
    public class Order: EntityBase
    {
        [Required]
        [ForeignKey("User")]
        public int CustomerId { get; set; }

        [Required]
        [ForeignKey("User")]
        public int OwnerId { get; set; }

        [Required]
        [ForeignKey("Car")]
        public int CarId { get; set; }

        [Required]
        public int Price { get; set; }

        public DateTime Bought { get; set; }

        public User? Customer { get; set; }

        public User? Owner { get; set; }

        public Car? Car { get; set; }

    }
}
