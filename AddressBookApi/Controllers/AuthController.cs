using AddressBookApi.Contract;
using AddressBookApi.Entities.DTO;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Web.Http.Results;

namespace AddressBookApi.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAddressService addressService;
        public AuthController(IAddressService addressService)
        {
            this.addressService = addressService;
        }

        /// <summary>
        /// This Post method used to login the user and the bearer tokken
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("signin")]
        public IActionResult Login(LoginDto login)  
        {
            Log.Information("Login method is triggered");
            try
            {
                var Token = addressService.GenerateToken(login);
                if (Token != null)
                {
                    Log.Information("Token Generated");
                    return Ok(Token);
                }
                else
                {
                    Log.Error("User does not exist");
                    return Unauthorized();
                }
            }
            catch(Exception e)
            {
                return StatusCode(500);
            }
        }
    }
}
