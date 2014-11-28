using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTPCommerciaux
{
    public interface ISalarie
    {
        /// <summary>
        /// Le nom.
        /// </summary>
        String Nom { get; }

        /// <summary>
        /// Le prénom.
        /// </summary>
        String Prenom { get; }

        /// <summary>
        /// Le numéro de sécu.
        /// </summary>
        String NumSecu { get; }

        /// <summary>
        /// L'ancienneté en année.
        /// </summary>
        int Anciennete { get; }
    }
}
