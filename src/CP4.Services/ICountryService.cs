using CP4.Services.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CP4.Services
{
    public interface ICountryService
    {
        Task<IEnumerable<CountriesResponse>> GetAllCountriesAsync();
        Task<CountriesResponse> GetCountryByNameAsync(string name);
    }
}
