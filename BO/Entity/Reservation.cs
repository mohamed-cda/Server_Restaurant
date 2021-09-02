using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BO.Entity
{
    public class Reservation
    { /// <summary>
      /// Représente un objet Réservation
      /// </summary>

              
        public int Id { get; set; }
        /// <summary>
        ///Nom du client
        /// </summary>

        public DateTime Date { get; set; }

        /// <summary>
        ///Nom du client
        /// </summary>
        public string Nom { get; set; }

            /// <summary>
            /// Prénom du client
            /// </summary>
        public string Prenom { get; set; }

            /// <summary>
            ///Num du téléphone client
            /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        ///Quantité
        /// </summary>
        public int Quantite { get; set; }
        public int Id_Menu { get; set; }
       
        public int Id_Formule { get; set; }

        public Reservation() { }


        
        public Reservation(int id, DateTime date, string nom, string prenom, string telephone, int quantite, int id_Menu, int id_Formule)
        {
            Id = id;
            Date = date;
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
            Quantite = quantite;
            Id_Menu = id_Menu;
            Id_Formule = id_Formule;


        }

        public override bool Equals(object obj)
        {
            return obj is Reservation reservation &&
                   Id == reservation.Id &&
                   Date == reservation.Date &&
                   Nom == reservation.Nom &&
                   Prenom == reservation.Prenom &&
                   Telephone == reservation.Telephone &&
                   Quantite == reservation.Quantite &&
                   Id_Menu == reservation.Id_Menu &&
                   Id_Formule == reservation.Id_Formule;
        }

        public override int GetHashCode()
        {
            int hashCode = 2097201684;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + Date.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nom);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Prenom);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Telephone);
            hashCode = hashCode * -1521134295 + Quantite.GetHashCode();
            hashCode = hashCode * -1521134295 + Id_Menu.GetHashCode();
            hashCode = hashCode * -1521134295 + Id_Formule.GetHashCode();
            return hashCode;
        }
    }



}
