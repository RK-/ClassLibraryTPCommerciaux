using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryTPCommerciaux
{
    [Serializable]
    public class NoteFrais
    {
        /// <summary>
        /// La date de la note de frais.
        /// </summary>
        private DateTime dateFrais;

        /// <summary>
        /// Accesseur en lecture de dateFrais.
        /// </summary>
        public DateTime DateFrais
        {
            get { return dateFrais; }
        }
        
        /// <summary>
        /// le numéro de la note de frais.
        /// </summary>
        protected int numFrais;

        /// <summary>
        /// Le montant à rembourser de la note de frais
        /// </summary>
        protected double montantARembourser;

        /// <summary>
        /// Vrai si la note de frais a été remboursé, faux si non.
        /// </summary>
        private bool fraisRembourse;

        /// <summary>
        /// Accesseur en lecture du fraisRembourse.
        /// </summary>
        public bool FraisRembourse
        {
            get { return fraisRembourse; }
        }

        /// <summary>
        /// Le commercial concerné par la note de frais.
        /// </summary>
        protected Commercial commercial;

        /// <summary>
        /// Constructeur de classe.
        /// </summary>
        /// <param name="dateFrais">La date de frais</param>
        /// <param name="commercial">Le commercial</param>
        public NoteFrais(DateTime dateFrais, Commercial commercial)
        {
            this.commercial = commercial;
            this.dateFrais = dateFrais;
            this.numFrais = this.commercial.getMesNotesFrais().Count + 1;
            this.setMontantARembourser();
            this.fraisRembourse = false;
            this.commercial.ajouterNoteFrais(this);
        }

        /// <summary>
        /// Accesseur du champ commercial.
        /// </summary>
        public Commercial Commercial
        {
            get { return commercial; }
            set { commercial = value; }
        }

        /// <summary>
        /// Accesseur en lecture du champ montantARembourser.
        /// </summary>
        public double MontantARembourser
        {
            get { return montantARembourser; }
        }

        /// <summary>
        /// La note de frais a été rembourser.
        /// Passe le champ fraisRembourses à vrai.
        /// </summary>
        public void setFraisRembourser()
        {
            this.fraisRembourse = true;
        }

        /// <summary>
        /// Valorise le champ montantARembourser grâce à la méthode calculMontantARembourser().
        /// </summary>
        protected void setMontantARembourser()
        {
            this.montantARembourser = calculMontantARembourser();
        }

        /// <summary>
        /// Méthode qui calcul le montant à rembourser.
        /// </summary>
        /// <returns>Le montant à rembourser.</returns>
        public virtual double calculMontantARembourser() 
        { 
            return 0;
        }

        /// <summary>
        /// Rédéfinition de la méthode ToString().
        /// </summary>
        /// <returns>le numéro, la date, le montant à rembourses et si la note à été remboursé ou non.</returns>
        public override String ToString()
        {
            String libRembourse = "Non Remboursé";
            if (this.fraisRembourse)
            {
                libRembourse = "Remboursé";
            }
            return String.Format("numéro : {0} - Date : {1} - montant à rembourser : {2} euros - {3}", this.numFrais, this.dateFrais, this.montantARembourser, libRembourse);
        }
    }
}