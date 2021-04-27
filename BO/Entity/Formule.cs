using API.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.BusinessObject
{
    public class Formule
    {
        /// <summary>
        /// id  de la formule
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Plat
        /// </summary>
        public Plat Plat { get; set; }

        /// <summary>
        /// Dessert
        /// </summary>
        public string Dessert { get; set; }
        /// <summary>
        /// Entree
        /// </summary>
        public string Entree { get; set; }

        
       

        /// <summary>
        /// Default constructor for API serialisation
        /// </summary>
        /// 
        public Formule() { }

        /// <summary>
        /// Constructeur utilitaire full properties
        /// </summary>
        /// <param name="id">Nom de l'ingrédient</param>
        /// <param name="plat">Prix de l'ingrédient</param>
        /// <param name="entree">Prix de l'ingrédient</param>
        /// <param name="dessert">Prix de l'ingrédient</param>
        public Formule(int id, Plat plat,string entree,string dessert)
        {
           Id = id;
           
            Entree = entree;
            Dessert = dessert;

        }
        public override bool Equals(object obj)
        {
            return obj is Formule formule &&
                   Id == formule.Id &&
                   Plat == formule.Plat;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Plat);
        }
    }
    }
