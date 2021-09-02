using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BO.Entity
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
        public string Label { get; set; }

        /// <summary>
        /// Dessert
        /// </summary>
        
        
        public Formule() { }

        /// <summary>
        /// Constructeur utilitaire full properties
        /// </summary>
        /// <param name="id">Nom de la formule</param>
        /// <param name="label">label de la formule</param>
        
        public Formule(int id, string label)
        {
           Id = id;
           Label = label;
        }
        public override bool Equals(object obj)
        {
            return obj is Formule formule &&
                   Id == formule.Id &&
                   Label == formule.Label;
        }

        public override int GetHashCode()
        {
            int hashCode = 478122909;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Label);
            return hashCode;
        }
    }
    }
