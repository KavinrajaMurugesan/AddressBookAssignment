using AddressBookApi.Entities.DTO;
using Microsoft.AspNetCore.SignalR;
using System.ComponentModel.DataAnnotations;

namespace AddressBookApi.Entities.Model
{

    /// <summary>
    /// Login credentails model of the user.
    /// </summary>
    public class LoginCredential:EntityBase
    {
        [Key]
        public  Guid Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }    
    }
}
