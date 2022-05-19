using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cargaison
{
    class Cargaison_aeriene: Cargaison
    {

        public Cargaison_aeriene(int d, float p, float v) :
     base(d, p, v)
        {

        }

        public override float cout()
        {
            float c;
            if (this.volume < 80000)
                c = 4 * this.distance * this.poids;
            else
                c = 6 * this.distance * this.poids;
            return c;
        }

        public override void affichage()
        {
            Console.WriteLine("====Cargaison aeriene ==========");
            Console.WriteLine(this.ToString());
            Console.WriteLine("Cout : "+this.cout());

        }
    }
}
