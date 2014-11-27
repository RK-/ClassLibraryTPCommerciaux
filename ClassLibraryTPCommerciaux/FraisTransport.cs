using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryTPCommerciaux
{
    [Serializable]
    public class FraisTransport : NoteFrais
    {
        /// <summary>
        /// Le nombre de kilomètre.
        /// </summary>
        private int nbKM;

        /// <summary>
        /// Constructeur de classe.
        /// </summary>
        /// <param name="date">La date de la note de frais de transport.</param>
        /// <param name="c">Le commercial de la note de frais de transport.</param>
        /// <param name="nbKM">Le nombre de km de la note de frais de transport.</param>
        public FraisTransport(DateTime date, Commercial c, int nbKM)
            : base(date, c)
        {
            this.nbKM = nbKM;
            this.setMontantARembourser();
        }

        /// <returns>Le montant à rembourser.</returns>
        public override double calculMontantARembourser()
        {
            if (this.commercial.PuissanceVoiture < 5)
            {
                return 0.1 * this.nbKM;
            }
            else if(this.commercial.PuissanceVoiture < 10)
            {
               return 0.2 * this.nbKM;
            }
            else
            {
                return 0.3 * this.nbKM;
            }
        }

        /// <returns>le numéro, la date, le montant à rembourses, si la note à été remboursé ou non et son nombre de km.</returns>
        public override string ToString()
        {
            String libRembourse = "Non Remboursé";
            if (this.FraisRembourse)
            {
                libRembourse = "Remboursé";
            }
            return String.Format("Transport -numéro : {0} - Date : {1} - montant à rembourser : {2} euros - {3}- {4} km-", this.numFrais, this.DateFrais, this.montantARembourser, libRembourse, this.nbKM);
        }
    }
}