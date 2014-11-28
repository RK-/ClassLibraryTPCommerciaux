using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTPCommerciaux
{
    public class EnumereChampsCommercial : IEnumerator
    {
        /// <summary>
        /// Le commercial.
        /// </summary>
        private Commercial leCommercial;

        /// <summary>
        /// L'index.
        /// </summary>
        private int index;

        /// <summary>
        /// Constructeur de classe.
        /// </summary>
        /// <param name="leCommercial">Le commercial</param>
        public EnumereChampsCommercial(Commercial leCommercial)
        {
            this.leCommercial = leCommercial;
            this.index = -1;
        }

        /// <summary>
        /// L'objet courant.
        /// </summary>
        public object Current
        {
            get
            {
                object o = null;
                switch (this.index)
                {
                    case 0:
                        {
                            o = this.leCommercial.Nom; break;
                        }
                    case 1:
                        {
                            o = this.leCommercial.Prenom; break;
                        }
                    case 2:
                        {
                            o = this.leCommercial.CategorieProfessionnelle; break;
                        }
                    case 3:
                        {
                            o = this.leCommercial.PuissanceVoiture; break;
                        }
                    case 4:
                        {
                            o = this.leCommercial.NumSecu; break;
                        }
                    case 5:
                        {
                            o = this.leCommercial.Anciennete; break;
                        }
                }
                return o;
            }
        }

        /// <summary>
        /// Index suivant.
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            this.index++;
            return this.index < 6;
        }

        /// <summary>
        /// Index reset.
        /// </summary>
        public void Reset()
        {
            this.index = -1;
        }
    }
}
