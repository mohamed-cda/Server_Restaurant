
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BLLC.Extensions;
using System.Net.Http.Json;
using API.BusinessObject;

namespace BLLC.Services
{
    public class ReservationService
    {
        private readonly HttpClient _httpClient;
        public ReservationService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:5001/api/");
        }

        public async Task<List<Reservation>> GetAllReservations()
        {
             //var reponse = await _httpClient.GetAsync($"reservation?page={pageRequest.Page}&pageSize={pageRequest.PageSize}");
           var reponse = await _httpClient.GetAsync(_httpClient.BaseAddress);

            // Si la requete a reussi
            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    List<Reservation> reservationsliste = await JsonSerializer.DeserializeAsync<List<Reservation>>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return reservationsliste;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<List<Reservation>> ModernGetAllReservations()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<Reservation>>(_httpClient.BaseAddress);
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
                var reponse =  await _httpClient.PostAsJsonAsync("Reservation", reservation);
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Reservation newReservation = await JsonSerializer.DeserializeAsync<Reservation>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return newReservation;
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
