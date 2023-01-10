using AddressBookApi.Contract;
using AddressBookApi.Entities.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace AddressBookApi.Controllers
{
    [ApiController]
    [Route("api/[Controller]/")]
    public class Meta_DataController : ControllerBase
    {
        private readonly IAddressService addressService;
        public Meta_DataController(IAddressService addressService)
        {
            this.addressService = addressService;
        }
        [HttpGet]
        [Route("set-ref/{Key}")]
        [Authorize]
        public IActionResult GetByKey(string Key)
        {
            Log.Information("GetByKey is Started");
            try
            {
                if (!string.IsNullOrEmpty(Key))
                {
                    RefSetDto refSetDto = addressService.GetMetadata(Key);
                    if (refSetDto != null)
                    {
                        Log.Information("meta data is found");
                        return Ok(refSetDto);
                    }
                }
                Log.Information("Meta data key not found");
                return NotFound("Key not found");
            }
            catch(Exception e)
            {
                return StatusCode(500);
            }
        }
    }
}
