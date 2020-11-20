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
        public Famille(string code, string libelle, int? nbMediAmm)
        {
            _Code = code;
            _Libelle = libelle;
            _NombreAMM = nbMediAmm;
        }
        
        private string _Code;
        private string _Libelle;
        private int? _NombreAMM;

        public string getCode()
        {
            return this._Code;
        }
        public void setCode(string code)
        {
            this._Code = code;
        }

        public string getLibelle()
        {
            return this._Libelle;
        }
        public void setLibelle(string libelle)
        {
            this._Libelle = libelle;
        }

        public int? getNombreAMM()
        {
            return this._NombreAMM;
        }
        
        
        
        
#region Fonctions SQL
        /// <summary>
        /// Récuperer toutes les familles depuis la base.
        /// </summary>
        /// <returns>Une liste de famille en lecture-seule.</returns>
        public static ReadOnlyCollection<Famille> ToutesLesFamilles()
        {
            List<Famille> familles = new List<Famille>();
            
            SqlDataReader reader = BDD.LireProcedure("prc_toutes_familles");

            while (reader.Read())
            {
                // récupérer toutes les familles une par une.
                familles.Add(new Famille(
                    reader["FAM_code"].ToString(),
                    reader["FAM_libelle"].ToString(),
                    int.Parse(reader["FAM_nbMediAmm"].ToString())
                ));
            }
            

            return familles.AsReadOnly();
        }
#endregion
    }
}
