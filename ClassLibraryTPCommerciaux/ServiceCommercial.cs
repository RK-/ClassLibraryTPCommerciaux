using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryTPCommerciaux
{
    [Serializable]
    public class ServiceCommercial
    {
        /// <summary>
        /// La liste des commerciaux dans le service commercial.
        /// </summary>
        private List<Commercial> lesCommerciaux;

        /// <summary>
        /// Constructeur de classe.
        /// </summary>
        public ServiceCommercial()
        {
            lesCommerciaux = new List<Commercial>();
        }

        /// <summary>
        /// Ajouter un commercial dans le service commercial.
        /// </summary>
        /// <param name="c">Le commercial</param>
        public void ajouterCommercial(Commercial c)
        {
            lesCommerciaux.Add(c);
        }

        /// <summary>
        /// Ajouter note de frais de transport.
        /// </summary>
        /// <param name="c">Le commercial.</param>
        /// <param name="date">La date.</param>
        /// <param name="nbKm">Le nombre de kilomètre.</param>
        public void ajouterNote(Commercial c, DateTime date, int nbKm)
        {
            NoteFrais uneNoteTrans = new FraisTransport(date, c, nbKm);
        }

        /// <summary>
        /// Ajouter note de frais de repas.
        /// </summary>
        /// <param name="c">Le commercial.</param>
        /// <param name="date">La date.</param>
        /// <param name="nbKm">Le nombre de kilomètre.</param>
        public void ajouterNote(Commercial c, DateTime date, double prix)
        {
            NoteFrais uneNoteRepas = new RepasMidi(date, c, prix);
        }

        /// <summary>
        /// Ajouter note de frais d'une nuitée.
        /// </summary>
        /// <param name="c">Le commercial.</param>
        /// <param name="date">La date.</param>
        /// <param name="nbKm">Le nombre de kilomètre.</param>
        public void ajouterNote(Commercial c, DateTime date, int montant, int region)
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
    }
}