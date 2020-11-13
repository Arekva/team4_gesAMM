using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Mama
{
    public static class Globale
    {
        /// <summary>
        /// Toutes les familles de médicament.
        /// </summary>
        public static Dictionary<string, Famille> Familles { get; }
        // le constructeur statique s'éxécute dès que quelque chose accède à cette classe.
        static Globale()
        {
            Famille[] familles = Famille.ToutesLesFamilles().ToArray();
            Familles = new Dictionary<string, Famille>(familles.Length);
            
            for (int i = 0; i < familles.Length; i++)
            {
                Familles.Add(familles[i].getCode(), familles[i]);
            }
        }
    }
}
