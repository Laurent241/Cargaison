using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cargaison
{
    class Cargaison_routiere: Cargaison
    {

        public Cargaison_routiere(int d, float p, float v):
            base(d, p, v)
        {

        }

        

        public override float cout()
        {
            float c;
            if (this.volume < 380000)
                c = 10 * this.distance * this.poids;
            else
                c = 12 * this.distance * this.poids;
            return c;
        }

        public override void affichage()
        {
            Console.WriteLine("====Cargaison routiere ==========");
            Console.WriteLine(this.ToString());

            Console.WriteLine("Cout : "+this.cout());
        }
    }
}
