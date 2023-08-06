using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Car_E_shop.Models
{
    public class User: EntityBase
    {
        // pro FK klíč:     public ICollection<Student> Students { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        
        [Required]
        public string Surname { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        [JsonIgnore]
        public string Password { get; set; } = string.Empty;

        [Required]
        public int Phone { get; set; }

        [Required]
        [JsonIgnore]
        public bool IsDeleted { get; set; }

        [Required]
        public DateTime LastLoggedIn { get; set; }

        [Required]
        public string TypeOfUser { get; set; } = string.Empty;

        public ICollection<Car>? Cars { get; set; }
    }


   
}
