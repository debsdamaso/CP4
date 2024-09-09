using CP4.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CP4.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountriesController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var countries = await _countryService.GetAllCountriesAsync();
            return Ok(countries);
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            var country = await _countryService.GetCountryByNameAsync(name);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }
    }
}
