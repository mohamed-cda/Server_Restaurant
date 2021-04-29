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
            Console.WriteLine("Hello World!");
            ReservationService reservationService = new ReservationService();

            //List<Reservation> reservationsPage = await reservationService.GetAllReservations();

            //reservationsPage.ForEach((reservation) =>
            //{
            //    Console.WriteLine(reservation.Nom);
            //});

            Console.ReadLine();

            //var resrvationsPage = await reservationService.ModernGetAllReservations(new PageRequest(){Page = 1 });
            //resrvationsPage.Data.ForEach((reservation) =>
            //{
            //    Console.WriteLine(reservation.Nom);
            //});


             var newReservation = await reservationService.ModernPostReservation(new Reservation(){Nom= "El Barkani", Prenom= "Moham", Date = DateTime.Now, Telephone = "0670331321", Quantite = 3, Id_menu = 1, Id_formule = 1 });
             Console.WriteLine("Le nouvelle id de lareservation est : " + newReservation.Id_reservation);


            /* "Nom" : "El Barkani", 
    "Prenom" : "Mohamed", 
    "Date" : "2011-03-19T07:22",
    "Telephone" : "0670331321",
    "quantite" : 1,
    "Id_menu" : 1,
    "Id_formule" :1*/
        }
    }
}
