using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTPCommerciaux
{
    public interface IVoyageurCommercial
    {
        /// <summary>
        /// Ajouter une note de frais.
        /// </summary>
        /// <param name="f"></param>
        void ajouterNoteFrais(NoteFrais f);

        /// <summary>
        /// Accesseur en lecture de la liste des notes de frais.
        /// </summary>
        List<NoteFrais> getMesNotesFrais();

        /// <summary>
        /// Le nom.
        /// </summary>
        String Nom { get; }

        /// <summary>
        /// Le prénom.
        /// </summary>
        String Prenom { get; }

        /// <summary>
        /// La catégorie professionnelle.
        /// </summary>
        char CategorieProfessionnelle { get; }

        /// <summary>
        /// La puissance de la voiture en ch.
        /// </summary>
        int PuissanceVoiture { get; }

        /// <summary>
        /// Le service commercial.
        /// </summary>
        ServiceCommercial LeService { get; }

        /// <summary>
        /// Ajouter un service commercial.
        /// </summary>
        /// <param name="sc">Le service commercial</param>
        void ajouterServiceCommercial(ServiceCommercial sc);

        /// <summary>
        /// Trier les notes de frais.
        /// </summary>
        void trierNotes();

        /// <summary>
        /// Méthode ToString
        /// </summary>
        /// <returns>Chaine de caractères.</returns>
        String ToString();
    }
}
