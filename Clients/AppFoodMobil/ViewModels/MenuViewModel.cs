using AppFoodMobil.Models;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFoodMobil.ViewModels
{
    class MenuViewModel : ViewModelBase
    {
        //date time piker



        private MenuM MvM;
       
        private DateTimeOffset _date = new DateTimeOffset(DateTime.Now);
        public DateTimeOffset Date
        {
            get => _date;
            set => Set(ref _date, value);
        }
        private string _entree;
        public string Entree
        {
            get => _entree;
            set => Set(ref _entree, value);
        }
        private string _plat;
        public string Plat
        {
            get => _plat;
            set => Set(ref _plat, value);
        }
        private string _dessert;
        public string Dessert
        {
            get => _dessert;
            set => Set(ref _dessert, value);
        }







        private string _nomPlat;
        public string NomPlat
        {
            get => _nomPlat;
            set => Set(ref _nomPlat, value);
        }
        private DateTimeOffset _dateMenu = new DateTimeOffset(DateTime.Now);
        public DateTimeOffset DateMenu
         {
             get => _dateMenu;
            set
            {
                Set(ref _dateMenu, value);
                // La date change
                RefreshMenuModel();
            }
         }
        private bool _isMidi;
        public bool IsMidi
        {
            get => _isMidi;
            set => Set(ref _isMidi, value);
        }


        private async void RefreshMenuModel()
        {
            MvM = new MenuM();
            await MvM.LoadListeDesMenu(DateMenu.DateTime, _isMidi);

            NomPlat = MvM.vueMenu.nom_plat;
            IsMidi = MvM.vueMenu.IsMidi;
            Entree = MvM.vueMenu.type_de_plat;
        }
    }
    
}

