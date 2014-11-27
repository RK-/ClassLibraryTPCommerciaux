using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ClassLibraryTPCommerciaux
{
    public static class PersisteServiceCommercial
    {
        public static void sauve(object objet, String chemin)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream flux = null;
            try
            {
                flux = new FileStream(chemin, FileMode.Create, FileAccess.Write);
                formatter.Serialize(flux, objet);
                flux.Flush();
            }
            catch { }
            finally
            {
                if (flux != null)
                    flux.Close();
            }
        }

        public static ServiceCommercial charge(String chemin)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream flux = null;
            try
            {
                flux = new FileStream(chemin, FileMode.Open, FileAccess.Read);

                return (ServiceCommercial)formatter.Deserialize(flux);
            }
            catch
            {
                return default(ServiceCommercial);
            }
            finally
            {
                if(flux != null)
                    flux.Close();
            }
        } 
    }
}
