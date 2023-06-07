using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contact_Management.Models
{
    public class Contact
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "Name length can't be less than 5 characters.")]
        public string Name { get; set; }
        [Required]
        [MaxLength(9, ErrorMessage = "Contact length can't be more than 9 digits.")]
        public int ContactNumber { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
