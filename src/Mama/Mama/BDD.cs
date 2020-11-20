using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Mama
{
    public static class BDD
    {
        /// <summary>
        /// Le nom du PC actuel, utilisé pour créer le login indépendamant du PC (lecture seule)
        /// </summary>
        public static string NomPC
        {
            get
            {
                return Environment.MachineName;
            }
        }
        
        /// <summary>
        /// Le nom de la base de données sur laquelle se connecter.
        /// </summary>
        public static string NomBase { get; set; } = "GSB_gesAMM";

        /// <summary>
        /// Le <see cref="string"/> de connexion utilisé pour se connecter à la base SQLServer. Voir <see cref=""/> 
        /// </summary>
        public static string ConnexionLogin
        {
            get
            {
                return $@"Data Source={NomPC}\SQLEXPRESS;Initial Catalog={NomBase};Integrated Security=True;MultipleActiveResultSets=True";
            }
        }

        /// <summary>
        /// La connexion SQLServer courrante. Utiliser <see cref="Connecter"/> pour se connecter (lecture seule).
        /// </summary>
        public static SqlConnection Connexion { get; private set; } = null;
        
        static BDD()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Connecter();
        }

        /// <summary>
        /// Se connecter à la base de donnée via un login. La connexion est stockée dans <see cref="Connexion"/>.
        /// </summary>
        /// <param name="login">Le login SQLServer de la base. Si non fournie <see cref="ConnexionLogin"/> sera utilisé.</param>
        public static void Connecter(string login = null)
        {
            Connexion = new SqlConnection(login ?? ConnexionLogin);
            Connexion.Open();
        }

        /// <summary>
        /// Lire une le résultat d'une procédure. 
        /// </summary>
        /// <param name="nom">Le nom de la procédure (ex: <code>prc_toutesLesFamilles</code>).</param>
        /// <param name="parametres">Les paramètres de la procédure. Ne rien mettre si aucun. Les paramètres sont séparés par des ,<br>(ex: new Parametre(...), new Parametre(...), ...</br></param>
        /// <returns>Le flux de sortie de la requête.</returns>
        public static SqlDataReader LireProcedure(string nom, params Parametre[] parametres)
        {
            SqlCommand commande = new SqlCommand(nom, Connexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            
            if (parametres != null)
            {
                for (int i = 0; i < parametres.Length; i++)
                {
                    Parametre p = parametres[i];

                    SqlParameter parametre = new SqlParameter(p.NomSQL, p.TypeSQL, p.Taille)
                    {
                        Value = p.Valeur
                    };

                    commande.Parameters.Add(parametre);
                }
            }
            
            return commande.ExecuteReader();
        }

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

        public static List<Medicament> tousLesMedicaments()
        {
            List<Medicament> lesMedicaments = new List<Medicament>();

            SqlDataReader reader = BDD.LireProcedure("prc_tous_medicaments");

            while (reader.Read())
            {
                // récupérer toutes les familles une par une.


                lesMedicaments.Add(new Medicament(
                    reader["MED_depotLegal"].ToString(),
                    reader["MED_nomCommercial"].ToString(),
                    reader["MED_composition"].ToString(),
                    reader["MED_effets"].ToString(),
                    reader["MED_contreIndications"].ToString(),
                    Globale.Familles[reader["MED_codeFamille"].ToString()]



                ));
            }


            return lesMedicaments;
        }
    }
}