using BO.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BO.DTO.Vuemenu
{
   public class VueMenu
    {
        public string nom_plat
        {
            get; set;
        }
        /// <summary>
        /// Limit entities on one page
        /// </summary>
        public DateTime date_du_menu
        {
            get; set;
        }
        /// <summary>
        /// Total count entities repository
        /// </summary>
        public bool IsMidi
        {
            get; set;
        }
        public string type_de_plat
        {
            get; set;
        }
        public List<Plat> Plats { get; set; }
        /// <summary>
        /// TotalPages
        /// </summary>

        public VueMenu()
        {
        }
        public VueMenu(string _nom_plat, DateTime _date_du_menu, bool _isMidi, string _type_de_plat, List<Plat> plats)
        {
            nom_plat = _nom_plat;
            date_du_menu = _date_du_menu;
            IsMidi =_isMidi;
            type_de_plat = _type_de_plat;
            Plats = Plats;


        }
    }
}
