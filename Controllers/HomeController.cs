using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;

namespace GlobalErrorHandler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]

        public IActionResult Get()
        {
            try
            {
                Address address = GetAddress();
                throw new Exception ("Error occured");
            }
            catch (Exception)
            {

                throw;
            }

        }
        private Address GetAddress()
        {
            return new Address
            {
                Country = "Nepal",
                State = "Bagmati",
                City = "Kathmandu",
                Street = "White Tower"
            };
        }
    }

    public class Address
    {
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string? Street { get; set; }
    }
}
