using API.BusinessObject;
using System;
using System.Collections.Generic;

namespace API.BO
{
    /// <summary>
    /// Représente un objet Plat
    /// </summary>
    
    public class Plat
    {
        /// <summary>
        /// Id du plat
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Nom du plat
        /// </summary>
        public string Nom {get; set;}

        /// <summary>
        /// Liste des ingrédients
        /// </summary>
       public List<Ingredient> IngedientListe { get; set; }

        /// <summary>
        /// Entree ou dessert
        /// </summary>
       

        /// <summary>
        /// Default constructor for API serialisation
        /// </summary>
        public Plat(){}

        /// <summary>
        /// Constructeur utilitaire full properties
        /// </summary>
        /// <param name="nom">Nom du plat</param>
        /// <param name="ingedientListe">Listes des ingrédient </param>
       
        
        public Plat(string nom, List<Ingredient> ingedientListe)
        {
            Nom = nom;
            IngedientListe = ingedientListe;
            
            
        }

        public override bool Equals(object obj)
        {
            return obj is Plat plat &&
                   Nom == plat.Nom;
            // a finir avec les autres parms
                   
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nom);
        }
    }
}