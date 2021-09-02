using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity
{
    public class TypePlat
    {
        public int Id_Type { get; set; }

        public string Label { get; set; }
       

        public TypePlat() { }

        /// <summary>
        /// Constructeur utilitaire full properties
        /// </summary>
        /// <param name="Id">id du plat</param>
        /// <param name="label">label du plat</param>

        public TypePlat(int id_Type, string label)
        {
            Id_Type = id_Type;
            Label =label;
            
        }

        public override string ToString()
        {
            return Label;
        }
    }
}
