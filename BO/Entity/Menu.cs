using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.BusinessObject
{
    public class Menu
    {
        /// <summary>
        /// Nom du de l ingrédient
        /// </summary>
        public string Id_menu { get; set; }

        /// <summary>
        /// Prix moyen de l'ingrédient
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Default constructor for API serialisation
        /// </summary>
        public Menu() { }

        /// <summary>
        /// Constructeur utilitaire full properties
        /// </summary>
        /// <param name="nom">Nom de l'ingrédient</param>
        /// <param name="prix">Prix de l'ingrédient</param>

        public Menu(string id_menu,DateTime date)
        {
            Id_menu = id_menu;
            Date = date;

        }
        public override bool Equals(object obj)
        {
            return obj is Menu menu &&
                   Id_menu == menu.Id_menu &&
                   Date == menu.Date;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id_menu, Date);
        }
    }
}
