using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryTPCommerciaux
{
    [Serializable]
    public class Commercial : IVoyageurCommercial, ISalarie, IEnumerable
    {
        /// <summary>
        /// Le nom du commercial.
        /// </summary>
        private String nom;

        /// <summary>
        /// Accesseur en lecture de nom.
        /// </summary>
        public String Nom
        {
            get { return nom; }
        }

        /// <summary>
        /// Le prénom du commercial.
        /// </summary>
        private String prenom;

        /// <summary>
        /// Accesseur en lecture de prenom.
        /// </summary>
        public String Prenom 
        {
            get { return prenom; } 
        }

        /// <summary>
        /// La catégorie professionnelle du commercial.
        /// </summary>
        private char categorieProfessionnelle;

        /// <summary>
        /// Accesseur en lecture de la catégorie professionnelle du commercial.
        /// </summary>
        public char CategorieProfessionnelle
        {
            get { return categorieProfessionnelle; }
        }

        /// <summary>
        /// La puissance en ch. du commercial.
        /// </summary>
        private int puissanceVoiture;

        /// <summary>
        /// Accesseur en lecture de puissanceVoiture.
        /// </summary>
        public int PuissanceVoiture
        {
            get { return puissanceVoiture; }
        }

        /// <summary>
        /// La liste des notes de frais du commercial.
        /// </summary>
        private List<NoteFrais> mesNotesFrais;

        /// <summary>
        /// Accesseur en lecture de la liste des notes de frais.
        /// </summary>
        /// <returns>La liste des notes de frais.</returns>
        public List<NoteFrais> getMesNotesFrais()
        {
            return mesNotesFrais;
        }

        /// <summary>
        /// Le service commercial du commercial.
        /// </summary>
        private ServiceCommercial leService;

        /// <summary>
        /// Accesseur en lecture de leService.
        /// </summary>
        public ServiceCommercial LeService 
        {
            get { return leService; }
        }

        /// <summary>
        /// Le numéro de sécu du commercial.
        /// </summary>
        private String numSecu;

        /// <summary>
        /// Accesseur en lecture du numéro de sécu.
        /// </summary>
        public String NumSecu
        {
            get { return numSecu; }
        }

        /// <summary>
        /// La date d'embauche du commercial.
        /// </summary>
        private DateTime dateEmbauche;

        /// <summary>
        /// Retourne l'ancienneté (nombre d'années) du commercial.
        /// </summary>
        public int Anciennete
        {
            get { return DateTime.Now.Year - dateEmbauche.Year; }
        }

        /// <summary>
        /// Constructeur de classe.
        /// </summary>
        /// <param name="unNom">Le nom du commercial</param>
        /// <param name="unPrenom">Le prénom du commercial</param>
        /// <param name="uneCategorieProfessionnelle">La catégorie professionelle du commercial</param>
        /// <param name="unePuissanceVoiture">La puissance en ch. du commercial.</param>
        public Commercial(String unNom, String unPrenom, int unePuissanceVoiture, char uneCategorieProfessionnelle)
        {
            this.nom = unNom; 
            this.prenom = unPrenom; 
            this.categorieProfessionnelle = uneCategorieProfessionnelle; 
            this.puissanceVoiture = unePuissanceVoiture; 
            this.mesNotesFrais = new List<NoteFrais>(); 
        }

        /// <summary>
        /// Constructeur de classe.
        /// </summary>
        /// <param name="unNom">Le nom</param>
        /// <param name="unPrenom">Le prénom</param>
        /// <param name="unePuissanceVoiture">La puissance de la voiture en ch</param>
        /// <param name="uneCategorieProfessionnelle">La catégorie professionnelle</param>
        /// <param name="de">La date embauche</param>
        /// <param name="numSe">Le numéro de sécu</param>
        public Commercial(String unNom, String unPrenom, int unePuissanceVoiture, char uneCategorieProfessionnelle, DateTime de, String numSe)
        {
            this.nom = unNom;
            this.prenom = unPrenom;
            this.categorieProfessionnelle = uneCategorieProfessionnelle;
            this.dateEmbauche = de;
            this.numSecu = numSe;
            this.puissanceVoiture = unePuissanceVoiture;
            this.mesNotesFrais = new List<NoteFrais>();
        }

        /// <summary>
        /// Constructeur de classe.
        /// </summary>
        /// <param name="n">Le nom</param>
        /// <param name="p">Le prénom</param>
        /// <param name="de">La date d'embauche</param>
        /// <param name="numSe">Le numéro de sécu</param>
        public Commercial(String n, String p, DateTime de, String numSe)
        {
            this.nom = n;
            this.prenom = p;
            this.dateEmbauche = de;
            this.numSecu = numSe;
            this.mesNotesFrais = new List<NoteFrais>();
        }

        /// <summary>
        /// Ajouter une note de frais pour le commercial.
        /// </summary>
        /// <param name="f">La note de frais</param>
        public void ajouterNoteFrais(NoteFrais f)
        {
            this.mesNotesFrais.Add(f); 
        }

        /// <summary>
        /// Ajouter le service commercial du commercial
        /// </summary>
        /// <param name="sc">Le service commercial</param>
        public void ajouterServiceCommercial(ServiceCommercial sc)
        {
            this.leService = sc;
        }

        // <summary>
        /// Cumul des notes de frais remboursées pour une année.
        /// </summary>
        /// <param name="annee">L'année</param>
        /// <returns>Le cumul des frais une année</returns>
        public double cumulNoteFraisRemboursees(int annee)
        {
            double fraisRemboursees = 0;
            foreach (NoteFrais f in mesNotesFrais)
            {
                if (f.FraisRembourse && f.DateFrais.Year == annee)
                {
                    fraisRemboursees += f.MontantARembourser;
                }
            }
            return fraisRemboursees; 
        }

        /// <summary>
        /// Trier les notes de frais par montant.
        /// </summary>
        public void trierNotes()
        {
            mesNotesFrais.Sort();
        }

        /// <summary>
        /// Rédéfinition de la méthode ToString().
        /// </summary>
        /// <returns>le nom, le prénom, la puissance de la voiture et la catégorie professionnelle du commercial.</returns>
        public override String ToString() 
        {
            return String.Format("Nom : {0} ; Prénom : {1} ; Puissance voiture : {2} ; Catégorie : {3} ", this.nom, this.prenom, this.puissanceVoiture, this.categorieProfessionnelle); 
        }

        /// <summary>
        /// Permet l'utilisation du foreach.
        /// </summary>
        /// <returns>IEnumerator</returns>
        public IEnumerator GetEnumerator()
        {
            EnumereChampsCommercial en = new EnumereChampsCommercial(this);
            return en;
        }
    }
}