using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity
{
   public class PlatIngredient
    {
        public string IdPlat { get; set; }

        /// <summary>
        /// Prix moyen de l'ingrédient
        /// </summary>
        public int Quantite { get; set; }

        public Ingredient Ingredient { get; set; }

        /// <summary>
        /// Default constructor for API serialisation
        /// </summary>
        public PlatIngredient() { }

        /// <summary>
        /// Constructeur utilitaire full properties
        /// </summary>
        /// <param name="nom">Nom de l'ingrédient</param>
        /// <param name="prix">Prix de l'ingrédient</param>

        public  PlatIngredient(string id, int qte)
        {
            IdPlat = id;
            Quantite = qte;

        }
        public override bool Equals(object obj)
        {
            return obj is  PlatIngredient platIng &&
                   IdPlat == platIng.IdPlat &&
                   Quantite == platIng.Quantite;
        }

        public override int GetHashCode()
        {
            int hashCode = -2103203845;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(IdPlat);
            hashCode = hashCode * -1521134295 + Quantite.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Ingredient>.Default.GetHashCode(Ingredient);
            return hashCode;
        }
    }
}
