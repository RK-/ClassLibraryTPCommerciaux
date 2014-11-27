using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryTPCommerciaux
{
    [Serializable]
    public class RepasMidi : NoteFrais
    {
        /// <summary>
        /// Le montant du repas.
        /// </summary>
        private double montantRepas;

        /// <summary>
        /// Constructeur de classe.
        /// </summary>
        /// <param name="date">La date du repas</param>
        /// <param name="c">Le commercial</param>
        /// <param name="montantRepas">Le montant du repas</param>
        public RepasMidi(DateTime date, Commercial c, double montantRepas) 
            : base(date, c)
        {
            this.montantRepas = montantRepas;
            this.setMontantARembourser();
        }

        /// <returns>Le montant à rembourser.</returns>
        public override double calculMontantARembourser()
        {
            double remboursement = 0;
            switch (commercial.CategorieProfessionnelle){
                case 'A':
                    if (this.montantRepas < 25)
                    {
                        remboursement = this.montantRepas;
                    }
                    else
                    {
                        remboursement = 25;
                    }
                    break;
                case 'B':
                    if (this.montantRepas < 22)
                    {
                        remboursement = this.montantRepas;
                    }
                    else
                    {
                        remboursement = 22;
                    }
                    break;
                default:
                    if (this.montantRepas < 20)
                    {
                        remboursement = this.montantRepas;
                    }
                    else
                    {
                        remboursement = 20;
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
            return String.Format("Transport -numéro : {0} - Date : {1} - montant à rembourser : {2} euros - {3}- Montant repas : {4} euros-", this.numFrais, this.DateFrais, this.montantARembourser, libRembourse, this.montantRepas);
        }
    }
}