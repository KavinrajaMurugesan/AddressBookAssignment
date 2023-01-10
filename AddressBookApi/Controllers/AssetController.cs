using AddressBookApi.Contract;
using AddressBookApi.Entities.DTO;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Security.Claims;

namespace AddressBookApi.Controllers
{
    [Route("api/[Controller]")]
    public class AssetController : ControllerBase
    {
        private readonly IAddressService addressService;
        public AssetController(IAddressService addressService)
        {
            this.addressService = addressService;
        }

        /// <summary>
        /// This Post Method for Upload the userImage
        /// </summary>
        /// <param name="file"></param>
        /// <returns>IActionresult</returns>
        [HttpPost]
        [Route("UploadFile")]
        [Authorize]
        public IActionResult Post(IFormFile file)
        {
            try
            {
                var identify = HttpContext.User.Identity as ClaimsIdentity;
                ClaimsIdentity identity = HttpContext.User.Identity as ClaimsIdentity;
                if (addressService.ValidateUser(identity))
                {
                    return Ok(addressService.UploadFile(file));
                }
                return Unauthorized();
            }
            catch(Exception e)
            {
                return StatusCode(500);
            }
        }

        /// <summary>
        /// This Get Method for download the userImage
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("DownloadFile/{Id}")]
        public IActionResult Get(Guid Id)
        {
            Log.Information("DownloadFile is triggered");
            try
            {
                var identify = HttpContext.User.Identity as ClaimsIdentity;
                ClaimsIdentity identity = HttpContext.User.Identity as ClaimsIdentity;
                if (addressService.ValidateUser(identity))
                {
                    FileDownloadDto image = addressService.FileDownload(Id);
                    return File(image.FileContent, image.FileType);
                }
                Log.Warning("Unauthorized user");
                return Unauthorized();
            }
            catch(Exception e)
            {
                return StatusCode(500);
            }
        }
    }
}

