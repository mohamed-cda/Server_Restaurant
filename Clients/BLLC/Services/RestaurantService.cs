using API.BO;
using API.BusinessObject;
using BO.DTO.Requests;
using BO.DTO.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BLLC.Services
{
    public class RestaurantService :IRestaurantService
    {
        private readonly HttpClient _httpClient;
        public RestaurantService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:5001/api/");
        }

        public async Task<PageResponse<Menu>> GetAllMenus(PageRequest pageRequest)
        {
            var reponse = await _httpClient.GetAsync($"Menu?page={pageRequest.Page}&pageSize={pageRequest.PageSize}");
            // var reponse = await _httpClient.GetAsync(_httpClient.BaseAddress);

            // Si la requete a reussi
            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    PageResponse<Menu> menusliste = await JsonSerializer.DeserializeAsync<PageResponse<Menu>>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return menusliste;
                }
            }
            else
            {
                return null;
            }
        }

        //public async Task<List<Reservation>> ModernGetAllReservations()
        //{
        //    try
        //    {
        //        return await _httpClient.GetFromJsonAsync<List<Reservation>>(_httpClient.BaseAddress);
        //    }
        //    catch (HttpRequestException e)
        //    {
        //        Console.WriteLine("An error occurred. (code:" + e.StatusCode.Value + ") => " + e.Message);
        //    }
        //    catch (NotSupportedException e)
        //    {
        //        Console.WriteLine("The content type is not supported.");
        //    }
        //    catch (JsonException e) // Invalid JSON
        //    {
        //        Console.WriteLine("Invalid JSON.");
        //    }
        //    return null;
        //}

        public async Task<Plat> CreatePlat(Plat plat)
        {
            var reponse = await _httpClient.PostAsync("Plat",
                new StringContent(
                    JsonSerializer.Serialize(plat), Encoding.UTF8, "application/json"
                    )
                );

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Plat platNew = await JsonSerializer.DeserializeAsync<Plat>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return platNew;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<Plat> ModernPostPlat(Plat plat)
        {
            try
            {
                var reponse = await _httpClient.PostAsJsonAsync("Plat", plat);
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Plat newPlat = await JsonSerializer.DeserializeAsync<Plat>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return newPlat;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("An error occurred. (code:" + e.StatusCode.Value + ") => " + e.Message);
            }
            catch (NotSupportedException e)
            {
                Console.WriteLine("The content type is not supported.");
            }
            catch (JsonException e) // Invalid JSON
            {
                Console.WriteLine("Invalid JSON.");
            }
            return null;
        }
    }
}
