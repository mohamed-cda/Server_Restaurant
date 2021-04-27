using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.BusinessObject
{
    public class Ingredient
    {
        /// <summary>
        /// Nom du de l ingrédient
        /// </summary>
        public string Nom { get; set; }
                
                /// <summary>
        /// Prix moyen de l'ingrédient
        /// </summary>
        public double Prix { get; set; }

        /// <summary>
        /// Default constructor for API serialisation
        /// </summary>
        public Ingredient() { }

        /// <summary>
        /// Constructeur utilitaire full properties
        /// </summary>
        /// <param name="nom">Nom de l'ingrédient</param>
        /// <param name="prix">Prix de l'ingrédient</param>
        
        public Ingredient(string nom, double prix)
        {
            Nom = nom;
            Prix = prix;
            
        }
                public override bool Equals(object obj)
        {
            return obj is Ingredient ingredient &&
                   Nom == ingredient.Nom &&
                   Prix == ingredient.Prix;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nom, Prix);
        }
    }
}
