using API.BusinessObject;
using BLLC.Services;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
           
            ReservationService reservationService = new ReservationService();

           
           

            //var resrvationsPage = await reservationService.ModernGetAllReservations(new PageRequest(){Page = 1 });
            //resrvationsPage.Data.ForEach((reservation) =>
            //{
            //    Console.WriteLine(reservation.Nom);
            //});


             var newReservation = await reservationService.ModernPostReservation(new Reservation(){Nom= "El Barkani", Prenom= "Moham", Date = DateTime.Now, Telephone = "0670331321", Quantite = 3, Id_menu = 1, Id_formule = 1 });
             Console.WriteLine("Le nouvelle id de lareservation est : " + newReservation.Id_reservation);


        }
    }
}
