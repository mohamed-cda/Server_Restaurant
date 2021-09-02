using BLLC.Services;
using BO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;

namespace AppFoodMobil.Models
{
    class ReservationM:ModelBase
    {
        int page = 1;
        int pageSize = 10;
        int maxPage = 1;
        DateTime dateMenu;
        private async Task AfficherListeDesMenu()
        {
            // recuperer la date pour avoir le menu

            PageRequest pageRequest = new PageRequest(page, pageSize);
            RestaurantService listeMenus = new RestaurantService();

            // recupere le menu de la semaine

            try
            {
                var reponse = await listeMenus.GetAllMenus(pageRequest);
                maxPage = reponse.TotalPages.GetValueOrDefault();
                var listeM = reponse.Data;
                
             


            }
            catch (Exception e)
            {
                var dialog = new MessageDialog("erreur de recuperation de données!");
                await dialog.ShowAsync();

            }

        }



        private async void BtnReservation_Click(object sender, RoutedEventArgs e)
        {
            ReservationService Reservation = new ReservationService();
            //ReservationM reservation = new ReservationM();
            //reservation.dateMenu = DateTime.Now;
          
           
           


           // var reponse = await Reservation.CreateReservation(reservation);
            //if (reponse.Id != 0)
            //{
            //    var me = new MessageDialog("votre reservation a été enregistré");

            //}
            //else
            //{
            //    var me = new MessageDialog("erreur de reservation");
            //}

        }
    }
}

