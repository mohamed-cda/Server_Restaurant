using AppFoodMobil.ViewModels;
using BLLC.Services;
using BO.DTO;
using BO.Entity;
using System;
using BO.DTO.Vuemenu;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace AppFoodMobil.Models
{
   public class MenuM : ModelBase

    {
        private VueMenu _Vmenu;
       
        public VueMenu vueMenu
        {
            get
            {
                return _Vmenu;
            }
            set
            {
                Set(ref _Vmenu, value);
            }
        }


        public MenuM()
        { // Recuperer la liste de la base de données
                
        }
        
        public async Task LoadListeDesMenu(DateTime date, bool isMidi)
        {
            // recuperer la date pour avoir le menu

            
            RestaurantService listeMenus = new RestaurantService();

            // recupere le menu de la semaine

            try
            {
                var reponse = await listeMenus.GetMenuByDate(date,isMidi);

               


            }
            catch (Exception e)
            {
                var dialog = new MessageDialog("erreur de recuperation de données!");
                await dialog.ShowAsync();

            }

        }


    }
}
