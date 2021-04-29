using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.BusinessObject
{
    public class Reservation
    { /// <summary>
      /// Représente un objet Réservation
      /// </summary>

        public int Id_reservation { get; set; }

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
        /// <summary>
        ///formules au choix (entrée, plat, dessert), (entrée et plat), (plat et dessert)
        /// </summary>
       

        public int Id_menu { get; set; }

        public int Id_formule { get; set; }

        /// <summary>
        /// Default constructor for API serialisation
        /// </summary>
        public Reservation() { }


        ///// <summary>
        ///// Constructeur utilitaire full properties
        ///// </summary>
        ///// <param name="Id">Date de réservation</param>
        ///// <param name="Date">Date de réservation</param>
        ///// <param name="Nom">Nom du client </param>
        ///// <param name="Prenom">Prénom du client </param>
        ///// <param name="Telephone"> Telephone </param>
        ///// <param name="MidiOuSoir">Midi ou soir</param>
        ///// <param name="Quantite">Quantite</param>
        ///// <param name="Formule">Formule</param>
        public Reservation(int id_reservation, DateTime date, string nom, string prenom, string telephone, bool midi_Ou_Soir, int quantite, int id_menu, int id_formule)
        {
            Id_reservation = id_reservation;
            Date = date;
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
            Quantite = quantite;
            Id_menu = id_menu;
            Id_formule = id_formule;
        }



        public override bool Equals(object obj)
            {
            return obj is Reservation reservation &&
                   Nom == reservation.Nom &&
                   Prenom == reservation.Prenom &&
                   Telephone == reservation.Telephone;
                      
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Nom, Prenom, Telephone, Quantite);
            }
        }


    
}
