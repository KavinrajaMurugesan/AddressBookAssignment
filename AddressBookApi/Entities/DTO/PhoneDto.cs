using System.ComponentModel.DataAnnotations;

namespace AddressBookApi.Entities.DTO
{
    /// <summary>
    /// this class gets phone details of the user in userdetails
    /// </summary>
    public class PhoneDto
    {
        [Required]
        public long PhoneNumber { get; set; }
        [Required]
        public Types Type { get; set; }
    }
}
