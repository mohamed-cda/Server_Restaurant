using BO.DTO;
using BO.DTO.Responses;
using BO.DTO.Vuemenu;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BLLC.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly HttpClient _httpClient = AuthentificationService.Getinstance().HttpClient;
        public RestaurantService()
        {
        }

        #region Menu
        public async Task<PageResponse<Menu>> GetAllMenus(PageRequest pageRequest)
        {
            var reponse = await _httpClient.GetAsync($"Menu?page={pageRequest.Page}&pageSize={pageRequest.PageSize}");
            // var reponse = await _httpClient.GetAsync(_httpClient.BaseAddress);

            // Si la requette a reussi
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

        

        public async Task<Menu> PostMenu(Menu menu)
        {
            try
            {
                var reponse = await _httpClient.PostAsJsonAsync("menu", menu);
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Menu newMenu = await JsonSerializer.DeserializeAsync<Menu>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return newMenu;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("An error occurred => " + e.Message);
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
        public async Task<Menu> ModifyMenu(Menu menu)
        {
            try
            {
                var reponse = await _httpClient.PutAsJsonAsync($"menu/{menu.Id_menu}", menu);
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Menu newMenu = await JsonSerializer.DeserializeAsync<Menu>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return newMenu;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("An error occurred => " + e.Message);
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

        public async Task<Menu> GetMenuByDate(DateTime dateMenu,bool isMidi)
        {
            try
            {
                var reponse = await _httpClient.GetAsync($"menu/date?dateMenu={dateMenu.ToString("d", CultureInfo.InvariantCulture)}");
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Menu newMenu = await JsonSerializer.DeserializeAsync<Menu>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return newMenu;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("An error occurred => " + e.Message);
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
        #endregion
        public async Task<bool> RemoveMenuById(Menu menu)
        {
            try
            {
                var reponse = await _httpClient.DeleteAsync($"menu/{menu.Id_menu}");
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {

                    return true;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("An error occurred => " + e.Message);
            }
            return false;
        }
        #region Ingredient
        public async Task<PageResponse<Ingredient>> GetAllIngredients(PageRequest pageRequest)
        {
            var reponse = await _httpClient.GetAsync($"Ingredient?page={pageRequest.Page}&pageSize={pageRequest.PageSize}");


            // Si la requete a reussi
            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    PageResponse<Ingredient> ingredientliste = await JsonSerializer.DeserializeAsync<PageResponse<Ingredient>>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return ingredientliste;
                }
            }
            else
            {
                return null;
            }
        }
        public async Task<Ingredient> CreateIngredient(Ingredient ingredient)
        {
            var reponse = await _httpClient.PostAsync("ingredient",
                new StringContent(
                    JsonSerializer.Serialize(ingredient), Encoding.UTF8, "application/json"
                    )
                );

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Ingredient ingredientNew = await JsonSerializer.DeserializeAsync<Ingredient>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return ingredientNew;
                }
            }
            else
            {
                return null;
            }
        }
        public async Task<Ingredient> ModifyIngredient(Ingredient ingredient)
        {
            try
            {
                var reponse = await _httpClient.PutAsJsonAsync($"ingredient/{ingredient.Id_ingredient}", ingredient);
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Ingredient newIngredient = await JsonSerializer.DeserializeAsync<Ingredient>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return newIngredient;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("An error occurred => " + e.Message);
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
        public async Task<bool> RemoveIngredientById(Ingredient ingredient)
        {
            try
            {
                var reponse = await _httpClient.DeleteAsync($"ingredient/{ingredient.Id_ingredient}");
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {

                    return true;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("An error occurred => " + e.Message);
            }
            return false;
        }
        #endregion
        
        #region Plat
        public async Task<PageResponse<Plat>> GetAllPlats(PageRequest pageRequest)
        {
            var reponse = await _httpClient.GetAsync($"Plat?page={pageRequest.Page}&pageSize={pageRequest.PageSize}");


            // Si la requete a reussi
            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    PageResponse<Plat> platliste = await JsonSerializer.DeserializeAsync<PageResponse<Plat>>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return platliste;
                }
            }
            else
            {
                return null;
            }
        }
        public async Task<Plat> GetAsync(int id)
        {
            try
            {
                var reponse = await _httpClient.GetAsync($"plat/{id}");
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Plat newPlat = await JsonSerializer.DeserializeAsync<Plat>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return newPlat;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("An error occurred => " + e.Message);
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


        public async Task<Plat> CreatePlat(Plat plat)
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
                Console.WriteLine("An error occurred => " + e.Message);
            }
            catch (NotSupportedException e)
            {
                Console.WriteLine("The content type is not supported.");
            }
            catch (JsonException e) // Invalid JSON
            {
                Console.WriteLine("Invalid JSON." + e.Message);
            }
            return null;
        }
        public async Task<Plat> ModifyPlat(Plat plat)
        {
            try
            {
                var reponse = await _httpClient.PutAsJsonAsync($"plat/{plat.Id_plat}", plat);
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Plat newPlat = await JsonSerializer.DeserializeAsync<Plat>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return newPlat;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("An error occurred => " + e.Message);
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
        public async Task<bool> RemovePlatById(Plat plat)
        {
            try
            {
                var reponse = await _httpClient.DeleteAsync($"plat/{plat.Id_plat}");
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {

                    return true;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("An error occurred=> " + e.Message);
            }
            return false;
        }
        public async Task<Reservation> CreateReservation(Reservation reservation)
        {
            try
            {
                var reponse = await _httpClient.PostAsJsonAsync("Reservation", reservation);
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Reservation newResrvation = await JsonSerializer.DeserializeAsync<Reservation>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return newResrvation;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("An error occurred => " + e.Message);
            }
            catch (NotSupportedException e)
            {
                Console.WriteLine("The content type is not supported.");
            }
            catch (JsonException e) // Invalid JSON
            {
                Console.WriteLine("Invalid JSON." + e.Message);
            }
            return null;
        }
        
        #endregion

    }
}
