using BO.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFoodMobil.ViewModels
{
    class ReservationModel:ViewModelBase
    {
        private string _titre = "Réservation";
        private string _nom = "";
        private string _prenom = "";
        private string _telephone = "";
        private DateTime _date;
        private int _quantite = 0;
        private string _service;
        private string _formule;


        private ObservableCollection<Menu> _menu;
        public ObservableCollection<Menu> Menu
        {
            get => _menu;
            set => Set(ref _menu, value);
        }

        public string Titre
        {
            get => _titre;
            set => Set(ref _titre, value);
        }
        public string Nom
        {
            get => _nom;
            set => Set(ref _nom, value);
        }
        public string Prenom
        {
            get => _prenom;
            set => Set(ref _prenom, value);
        }
        public string Telephone
        {
            get => _telephone;
            set => Set(ref _telephone, value);
        }
        public DateTime Date
        {
            get => _date;
            set => Set(ref _date, value);
        }
        public int Quantite
        {
            get => _quantite;
            set => Set(ref _quantite, value);
        }
        public string Service
        {
            get => _service;
            set => Set(ref _service, value);
        }
        public string Formule
        {
            get => _formule;
            set => Set(ref _formule, value);
        }
    }
}
