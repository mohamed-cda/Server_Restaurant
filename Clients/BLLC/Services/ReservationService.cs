using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BLLC.Extensions;
using System.Net.Http.Json;
using BO.DTO.Responses;
using BO.Entity;
using BO.DTO;

namespace BLLC.Services
{
    public class ReservationService : IReservationService
    {
        private readonly HttpClient _httpClient = AuthentificationService.Getinstance().HttpClient;
        public ReservationService()
        {
            
        }

        

        public async Task<PageResponse<Reservation>> GetAllReservations(PageRequest pageRequest)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<PageResponse<Reservation>>($"Reservation?page={pageRequest.Page}&pageSize={pageRequest.PageSize}");
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
        public async Task<PageResponse<Menu>> GetAllMenus(PageRequest pageRequest)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<PageResponse<Menu>>($"ListeMenu?page={pageRequest.Page}&pageSize={pageRequest.PageSize}");
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
        
        public async Task<Reservation> CreateReservation(Reservation reservation)
        {
            var reponse = await _httpClient.PostAsync("Reservation",
                new StringContent(
                    JsonSerializer.Serialize(reservation), Encoding.UTF8, "application/json"
                    )
                );

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Reservation reservationNew = await JsonSerializer.DeserializeAsync<Reservation>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return reservationNew;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<Reservation> ModernPostReservation(Reservation reservation)
        {
            try
            {
                var reponse = await _httpClient.PostAsJsonAsync("Reservation", reservation);
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Reservation newReservation = await JsonSerializer.DeserializeAsync<Reservation>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return newReservation;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("An error occurred=> " + e.Message);
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