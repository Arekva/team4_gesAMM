using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mama
{
    static class Globale
    {
        /// <summary>
        /// Toutes les familles de médicament.
        /// </summary>
        public static Dictionary<string, Famille> Familles { get; } = new Dictionary<string, Famille>();
        public static Dictionary<string, Medicament> Medicaments  = new Dictionary<string, Medicament>(); 
        public static Dictionary<int, Etape> Etapes = new Dictionary<int, Etape>();
        public static Dictionary<int, Utilisateur> Utilisateurs = new Dictionary<int, Utilisateur>();
        public static Dictionary<int, Decision> Decisions = new Dictionary<int, Decision>();

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


            foreach(Etape lEtape in BDD.toutesLesEtapes())
            {
                Etapes.Add(lEtape.getNumero(), lEtape);
            }
            foreach(Decision laDescision in BDD.toutesLesDecision())
            {
                Decisions.Add(laDescision.getID(), laDescision);
            }

            foreach(Utilisateur lUtilisateur in BDD.TousLesUtilisateurs())
            {
                Utilisateurs.Add(lUtilisateur.getId(), lUtilisateur);
            }

        }
    }
}
