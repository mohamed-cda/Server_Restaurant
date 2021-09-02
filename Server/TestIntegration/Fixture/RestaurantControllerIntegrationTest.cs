using API;
using BO.Entity;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestIntegration.Fixture
{
    public class RestaurantControllerIntegrationTest:IntergrationTest
    {
        public RestaurantControllerIntegrationTest(WebApplicationFactory<Startup> factory) : base(factory) { }
        [Fact]
        public async Task GetMenuById_should_Be_Ok()
        {
            
            // Arrange
            Menu expected = new Menu()
            {
                Id_menu = 2,
                Date = DateTime.Now
            };
            // Act
            try
            {
                var response = await _client.GetFromJsonAsync<Menu>("api/v1/Menu/2");
                // Assert
                Assert.Equal(response, expected);
            }
            catch
            {
                Assert.True(false);
            }
           




        }
    }
}
