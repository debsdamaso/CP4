using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CP4.Services
{
    public class CountryService : ICountryService
    {
        private readonly HttpClient _httpClient;
        private const string ApiUrl = "https://restcountries.com/v3.1/all";

        public CountryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<CountriesResponse>> GetAllCountriesAsync()
        {
            try
            {
                var response = await _httpClient.GetStringAsync(ApiUrl);
                var countries = JsonConvert.DeserializeObject<List<CountriesResponse>>(response);
                return countries ?? new List<CountriesResponse>();
            }
            catch (JsonException e)
            {
                // Log the error and return an empty list or handle the error as needed
                throw new Exception("Error deserializing country data", e);
            }
            catch (HttpRequestException e)
            {
                // Log the error and handle the request failure
                throw new Exception("Error fetching countries data", e);
            }
        }

        public async Task<CountriesResponse> GetCountryByNameAsync(string name)
        {
            try
            {
                var response = await _httpClient.GetStringAsync($"{ApiUrl}?name={name}");
                var countries = JsonConvert.DeserializeObject<List<CountriesResponse>>(response);
                return countries?.FirstOrDefault();
            }
            catch (JsonException e)
            {
                // Log the error and return null or handle the error as needed
                throw new Exception($"Error deserializing data for country: {name}", e);
            }
            catch (HttpRequestException e)
            {
                // Log the error and handle the request failure
                throw new Exception($"Error fetching data for country: {name}", e);
            }
        }
    }
}
