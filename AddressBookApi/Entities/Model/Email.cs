using AddressBookApi.Entities.DTO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AddressBookApi.Entities.Model
{
    /// <summary>
    /// Email details of the User.
    /// </summary>
    public class Email:EntityBase
    {
        [Key]
        public Guid EmailId { get; set; }
        [Required]
        public string? EmailAddress { get; set; }
        [Required]
        public Guid RefTermEmailId { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public UserDetails UserDetails { get; set; }
    }
}
