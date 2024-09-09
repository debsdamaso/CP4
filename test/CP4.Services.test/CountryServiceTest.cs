using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace CP4.Services.test
{
    public class CountryServiceTests
    {
        [Fact]
        public async Task GetAllCountries_ShouldReturnCountries()
        {
            // Arrange
            var mockHttpClient = new Mock<HttpClient>();
            var service = new CountryService(mockHttpClient.Object);

            // Act
            var result = await service.GetAllCountriesAsync();

            // Assert
            Assert.NotNull(result);
        }
    }
}
