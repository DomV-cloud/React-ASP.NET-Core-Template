using System.ComponentModel.DataAnnotations;

namespace Car_E_shop.Models
{
    public abstract class EntityBase
    {
        [Key]
        [Required]
        public int Id { get; set; }
    }
}
