using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTPCommerciaux
{
    public class ServiceComptable
    {
        /// <summary>
        /// La liste des salariés.
        /// </summary>
        private List<ISalarie> lesSalaries;

        /// <summary>
        /// Constructeur de classe.
        /// </summary>
        public ServiceComptable()
        {
            lesSalaries = new List<ISalarie>();
        }

        /// <summary>
        /// Ajouter un salarie dans la liste lesSlaries.
        /// </summary>
        /// <param name="s">Le salarie</param>
        public void ajouteSalarie(ISalarie s)
        {
            lesSalaries.Add(s);
        }

        /// <summary>
        /// Renvoie le salarie à un index donnée.
        /// </summary>
        /// <param name="i">Index</param>
        /// <returns>Le salarié</returns>
        public ISalarie getSalarie(int i)
        {
            return lesSalaries[i];
        }
    }
}
