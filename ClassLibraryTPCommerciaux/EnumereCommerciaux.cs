using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTPCommerciaux
{
    public class EnumereCommerciaux : IEnumerator
    {
        /// <summary>
        /// Le service commercial.
        /// </summary>
        private ServiceCommercial leService;

        /// <summary>
        /// L'index.
        /// </summary>
        private int index ;

        /// <summary>
        /// Constructeur de classe.
        /// </summary>
        /// <param name="leService">Le servie commercial</param>
        public EnumereCommerciaux(ServiceCommercial leService)
        {
           this.leService = leService;
           this.index = -1;
        }

        /// <summary>
        /// Index courant.
        /// </summary>
       public object Current
        {
            get { return this.leService.getCommercial(this.index); }
        }

        /// <summary>
        /// Le suivant.
        /// </summary>
        /// <returns>Index suivant.</returns>
        public bool MoveNext()
        {
            this.index++;
            return this.index < this.leService.nbCommerciaux();
        }

        /// <summary>
        /// Reset de l'index.
        /// </summary>
        public void Reset()
        {
            index = -1;
        }
    }
}
