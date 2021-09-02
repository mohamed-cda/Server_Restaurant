using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BO.Entity
{
    public class Menu
    {
        /// <summary>
        /// Nom du menu
        /// </summary>
        public int Id_menu { get; set; }

        /// <summary>
        /// service 
        /// </summary>
        
        public bool IsMidi{ get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Plats
        /// </summary>
        public List<Plat> Plats { get; set; }

        /// <summary>
        /// Default constructor for API serialisation
        /// </summary>
        public Menu() { }

        /// <summary>
        /// Constructeur utilitaire full properties
        /// </summary>
        /// <param name="Id">Id du menu</param>
        /// <param name="Date">date du menu</param>

        public Menu(int id, bool isMidi,DateTime date, List<Plat> plats)
        {
            Id_menu = id;
            IsMidi = isMidi;
            Date = date;
            Plats = plats;

        }
        public override bool Equals(object obj)
        {
            return obj is Menu menu &&
                   Id_menu == menu.Id_menu &&
                   Date == menu.Date;
        }

        public override int GetHashCode()
        {
            int hashCode = 2074505245;
            hashCode = hashCode * -1521134295 + Id_menu.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(IsMidi);
            hashCode = hashCode * -1521134295 + Date.GetHashCode();
            return hashCode;
        }
    }
}
