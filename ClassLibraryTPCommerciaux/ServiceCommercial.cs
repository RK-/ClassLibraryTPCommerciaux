using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryTPCommerciaux
{
    [Serializable]
    public class ServiceCommercial : IEnumerable
    {
        /// <summary>
        /// La liste des commerciaux dans le service commercial.
        /// </summary>
        private List<IVoyageurCommercial> lesCommerciaux;

        /// <summary>
        /// Constructeur de classe.
        /// </summary>
        public ServiceCommercial()
        {
            lesCommerciaux = new List<IVoyageurCommercial>();
        }

        /// <summary>
        /// Ajouter un commercial dans le service commercial.
        /// </summary>
        /// <param name="c">Le commercial</param>
        public void ajouterCommercial(IVoyageurCommercial c)
        {
            lesCommerciaux.Add(c);
            c.ajouterServiceCommercial(this);
        }

        /// <summary>
        /// Ajouter note de frais de transport.
        /// </summary>
        /// <param name="c">Le commercial.</param>
        /// <param name="date">La date.</param>
        /// <param name="nbKm">Le nombre de kilomètre.</param>
        public void ajouterNote(IVoyageurCommercial c, DateTime date, int nbKm)
        {
            NoteFrais uneNoteTrans = new FraisTransport(date, c, nbKm);
        }

        /// <summary>
        /// Ajouter note de frais de repas.
        /// </summary>
        /// <param name="c">Le commercial.</param>
        /// <param name="date">La date.</param>
        /// <param name="nbKm">Le nombre de kilomètre.</param>
        public void ajouterNote(IVoyageurCommercial c, DateTime date, double prix)
        {
            NoteFrais uneNoteRepas = new RepasMidi(date, c, prix);
        }

        /// <summary>
        /// Ajouter note de frais d'une nuitée.
        /// </summary>
        /// <param name="c">Le commercial.</param>
        /// <param name="date">La date.</param>
        /// <param name="nbKm">Le nombre de kilomètre.</param>
        public void ajouterNote(IVoyageurCommercial c, DateTime date, int montant, int region)
        {
            NoteFrais uneNoteNuitee = new Nuitee(date, c, region, montant);
        }

        /// <summary>
        /// Méthode qui renvoi le nombre de frais non remboursés.
        /// </summary>
        /// <returns>le nombre de frais non remboursés</returns>
        public int nbFraisNonRembourses()
        {
            int compteur = 0;
            foreach (Commercial c in lesCommerciaux)
            {
                foreach (NoteFrais f in c.getMesNotesFrais())
                {
                    if (f.FraisRembourse == false)
                    {
                        compteur++;
                    }
                }
            }
            return compteur;
        }

        /// <summary>
        /// Le nombre de commerciaux.
        /// </summary>
        /// <returns></returns>
        public int nbCommerciaux()
        {
            return lesCommerciaux.Count;
        }

        /// <summary>
        /// L'IVoyageurCommercial à l'index donné.
        /// </summary>
        /// <param name="i">L'index</param>
        /// <returns>L'IVoyageurCommercial</returns>
        public IVoyageurCommercial getCommercial(int i)
        {
            return lesCommerciaux[i];
        }

        /// <summary>
        /// Permet l'utilisation du foreach.
        /// </summary>
        /// <returns>IEnumerator</returns>
        public IEnumerator GetEnumerator()
        {
            EnumereCommerciaux en = new EnumereCommerciaux(this);
            return en;
        }
    }
}