using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BO.Entity
{
    public class Ingredient
    { public int Id_ingredient { get; set; }
        /// <summary>
        /// Nom du de l ingrédient
        /// </summary>
        public string Nom { get; set; }
                
                /// <summary>
        /// Prix moyen de l'ingrédient
        /// </summary>
        public float Prix { get; set; }

        /// <summary>
        /// Default constructor for API serialisation
        /// </summary>
        public Ingredient() { }

        /// <summary>
        /// Constructeur utilitaire full properties
        /// </summary>
        /// <param name="nom">Nom de l'ingrédient</param>
        /// <param name="prix">Prix de l'ingrédient</param>
        
        public Ingredient(int id, string nom, float prix)
        {
            Id_ingredient = id;
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
            int hashCode = 791861747;
            hashCode = hashCode * -1521134295 + Id_ingredient.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nom);
            hashCode = hashCode * -1521134295 + Prix.GetHashCode();
            return hashCode;
        }
    }
}
