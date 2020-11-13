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
        /// Nouvelle famille où tous les paramètres sont fournis.
        /// </summary>
        /// <param name="code">Le code identifiant de la famille.</param>
        /// <param name="libelle">Le libelle de la famille.</param>
        /// <param name="nbMediAmm">Le nombre de médicaments qui ont eu une validation</param>
        public Famille(string code, string libelle, int nbMediAmm)
        {
            _Code = code;
            _Libelle = libelle;
            _NombreAMM = nbMediAmm;
        }
        
        private string _Code;
        private string _Libelle;
        private int _NombreAMM;

        public string getCode()
        {
            return this._Code;
        }

        public string getLibelle()
        {
            return this._Libelle;
        }

        public int NombreAMM()
        {
            return this._NombreAMM;
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
