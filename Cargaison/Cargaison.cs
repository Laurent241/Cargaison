using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cargaison
{
   abstract class Cargaison
    {

        protected static int cpt = 0;
        protected readonly int reference; 
        protected int distance;
        protected float poids;
        protected float volume;

        public Cargaison(int d, float p, float v)
        {
            ++cpt;
            this.reference = cpt;
            this.distance = d;
            this.poids = p;
            this.volume = v;

        }

        public virtual float cout()
        {
            return 0;
        }

        public override string ToString()
        {
            string s = " Reference : " + this.reference + " \n Parcours : " + this.distance + " \n Poids : " + this.poids + " \n Volume : " + this.volume;

            return s;
        }
        public virtual void affichage()
        {
             
        }
    }
}
