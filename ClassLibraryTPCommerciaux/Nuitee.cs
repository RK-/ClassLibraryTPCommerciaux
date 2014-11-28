using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryTPCommerciaux
{
    [Serializable]
    public class Nuitee : NoteFrais
    {
        /// <summary>
        /// Le montant de la note.
        /// </summary>
        private double montant;

        /// <summary>
        /// Code de la région touristique.
        /// </summary>
        private int regionTouristique;

        /// <summary>
        /// Constructeur de classe.
        /// </summary>
        /// <param name="date">La date de la note</param>
        /// <param name="c">Le commercial</param>
        /// <param name="region">Le code de la région touristique</param>
        /// <param name="montant">Le montant de la note</param>
        public Nuitee(DateTime date, IVoyageurCommercial c, int region, double montant)
            : base(date, c)
        {
            this.regionTouristique = region;
            this.montant = montant;
            this.setMontantARembourser();
        }

        /// <returns>Le montant à rembourser.</returns>
        public override double calculMontantARembourser()
        {
            double remboursement = 0;
            double coef = 0;
            switch (regionTouristique)
            {
                case '1':
                    coef = 0.90;
                    break;
                case '2':
                    coef = 1;
                    break;
                default:
                    coef = 1.15;
                    break;
            }
            switch (commercial.CategorieProfessionnelle)
            {
                case 'A':
                    if (this.montant < 65 * coef)
                    {
                        remboursement = this.montant;
                    }
                    else
                    {
                        remboursement = 65 * coef;
                    }
                    break;
                case 'B':
                    if (this.montant * coef < 55 * coef)
                    {
                        remboursement = this.montant;
                    }
                    else
                    {
                        remboursement = 55 * coef;
                    }
                    break;
                default:
                    if (this.montant < 50 * coef)
                    {
                        remboursement = this.montant;
                    }
                    else
                    {
                        remboursement = 50 * coef;
                    }
                    break;
            }
            return remboursement;
        }

        /// <returns>le numéro, la date, le montant à rembourses et si la note à été remboursé ou non.</returns>
        public override string ToString()
        {
            String libRembourse = "Non Remboursé";
            if (this.FraisRembourse)
            {
                libRembourse = "Remboursé";
            }
            return String.Format("Transport -numéro : {0} - Date : {1} - montant à rembourser : {2} euros - {3}- région : {4}- montant : {5} euros-", this.numFrais, this.DateFrais, this.montantARembourser, libRembourse, this.regionTouristique, this.montant);
        }
    }
}
