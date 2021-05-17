using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity
{
    public class TypePlat
    {
        public string Plat { get; set; }

        /// <summary>
        /// Prix moyen de l'ingrédient
        /// </summary>
        public string Entree { get; set; }
        public string Dessert { get; set; }
        public string EntreePlat { get; set; }
        public string DessertPlat { get; set; }

        /// <summary>
        /// Default constructor for API serialisation
        /// </summary>
        public TypePlat() { }

        /// <summary>
        /// Constructeur utilitaire full properties
        /// </summary>
        /// <param name="nom">Nom de l'ingrédient</param>
        /// <param name="prix">Prix de l'ingrédient</param>

        public TypePlat(string nom, string entree,string dessert,string entreePlat,string dessertPlat)
        {
            Plat = nom;
            Entree =entree;
            Dessert = dessert;
            EntreePlat = entreePlat;
            DessertPlat = dessertPlat;

        }
        //public override bool Equals(object obj)
        //{
        //    return obj is TypePlat typePlat &&
        //           Nom == TypePlat.Nom &&
        //           Prix == ingredient.Prix;
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Nom, Prix);
        //}
    
}
}
