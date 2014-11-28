using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTPCommerciaux
{
    public class Ecran
    {
        /// <summary>
        /// Affiche la description avec ToString tous les IVoyageurCommercial du serviceCommercial donné.
        /// </summary>
        /// <param name="sc">Le service commercial</param>
        public static void affiche(ServiceCommercial sc)
        {
            /*for (int i = 0; i < sc.nbCommerciaux(); i++)
            {
                affiche(sc.getCommercial(i));
            }*/
            foreach(Commercial c in sc)
            {
                affiche(c);
            }
        }

        /// <summary>
        /// Affiche la description avec ToString d'un IVoyageurCommercial.
        /// </summary>
        /// <param name="voyageurCommercial"></param>
        public static void affiche(IVoyageurCommercial voyageurCommercial)
        {
            Console.WriteLine(voyageurCommercial.ToString());
        }
    }
}
