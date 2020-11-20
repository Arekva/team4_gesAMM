using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Mama
{
    static class Globale
    {
        /// <summary>
        /// Toutes les familles de médicament.
        /// </summary>
        public static Dictionary<string, Famille> Familles { get; } = new Dictionary<string, Famille>();
        public static Dictionary<string, Medicament> Medicaments  = new Dictionary<string, Medicament>(); 

        public static Dictionary<string, Etape> Etapes = new Dictionary<string, Etape>();

        public static Dictionary<string, Decision> Decisions = new Dictionary<string, Decision>();

        // le constructeur statique s'éxécute dès que quelque chose accède à cette classe.
        static Globale()
        {
            foreach (Famille famille in BDD.ToutesLesFamilles())
            {
                Familles.Add(famille.getCode(), famille);
            }


            foreach(Medicament leMedo in BDD.tousLesMedicaments())
            {
                Medicaments.Add(leMedo.getDepotLegal(), leMedo);
            }
            /* rajouter aprés la procédure tous les medicaments
            foreach(Decision laDescision in BDD.toutesLesDecision())
            {
                Etapes.Add(laDescision.getID(), laDescision);
            }*/
        }
    }
}
