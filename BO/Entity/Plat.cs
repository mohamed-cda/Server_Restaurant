using System;
using System.Collections.Generic;

namespace BO.Entity
{
    /// <summary>
    /// Représente un objet Plat
    /// </summary>

    public class Plat
    {
        /// <summary>
        /// Id du plat
        /// </summary>
        public int Id_plat { get; set; }
        /// <summary>
        /// Nom du plat
        /// </summary>
        public string Nom { get; set; }
        public int Id_Type { get; set; }
        public TypePlat Type { get; set; }
        public List<Ingredient> Ingredient { get; set; }




        public Plat(){}

        /// <summary>
        /// Constructeur utilitaire full properties
        /// </summary>
        /// <param name="id">id du plat</param>
        /// <param name="nom">nom du plat </param>
       
        
        

        public Plat(int id_plat, string nom, int id_Type, TypePlat type, List<Ingredient> ingredient)
        {
            Id_plat = id_plat;
            Nom = nom;
            Id_Type = id_Type;
            Type = type;
            Ingredient = ingredient;
        }
    }
}