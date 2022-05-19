using System;

namespace Cargaison
{
    class Program
    {
        static void Main(string[] args)
        {
            Cargaison_routiere C1 = new Cargaison_routiere(11, 2, 2);
            Cargaison_aeriene C2 = new Cargaison_aeriene(10, 5, 4);
            C1.affichage();
            C2.affichage();

        }
    }
}
