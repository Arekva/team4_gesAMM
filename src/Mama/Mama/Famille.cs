using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mama
{
    /// <summary>
    /// Famille / type de médicament.
    /// </summary>
    public class Famille
    {
        /// <summary>
        /// Identifiant unique de la famille.
        /// </summary>
        public string Code { get; } = null;

        /// <summary>
        /// Nom du médicament.
        /// </summary>
        public string Libelle { get; } = null;

        /// <summary>
        /// Nombre de médicament qui ont reçu une validation AMM.
        /// </summary>
        public int NombreAMM { get; set; } = 0;
        /// <summary>
        /// Nouvelle famille où tous les paramètres sont fournis.
        /// </summary>
        /// <param name="code">Le code identifiant de la famille.</param>
        /// <param name="libelle">Le libelle de la famille.</param>
        /// <param name="nbMediAmm">Le nombre de médicaments qui ont eu une validation</param>
        public Famille(string code, string libelle, int nbMediAmm)
        {
            Code = code;
            Libelle = libelle;
            NombreAMM = nbMediAmm;
        }
        
        
#region Fonctions SQL
        /// <summary>
        /// Récuperer toutes les familles dans la base.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Non testé !")]
        public static ReadOnlyCollection<Famille> ToutesLesFamilles()
        {
            List<Famille> familles = new List<Famille>();

            //todo: changer le nom de la procédure.
            SqlDataReader reader = BDD.LireProcedure("prc_familles");
            while (reader.Read())
            {
                // récupérer toutes les familles une par une.
                familles.Add(new Famille(
                    reader["FAM_code"].ToString(),
                    reader["FAM_libelle"].ToString(),
                    int.Parse(reader["FAM_nbMediArm"].ToString())
                    ));
            }

            BDD.LireProcedure("prc_test", new Parametre("@idTest", 5, 3));

            return familles.AsReadOnly();
        }
#endregion
    }
}
