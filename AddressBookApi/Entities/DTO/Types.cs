using System.ComponentModel.DataAnnotations;

namespace AddressBookApi.Entities.DTO
{

    /// <summary>
    /// This class used for the metadat type of the phone,addresss,email
    /// </summary>
    public class Types
    {
        [Required]
        public string? Key { get; set; }
    }
}
