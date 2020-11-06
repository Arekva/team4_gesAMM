using System;
using System.Data.SqlClient;

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
                return @$"Data Source={NomPC}\SQLEXPRESS;Initial Catalog={NomBase};Integrated Security=True;MultipleActiveResultSets=True";
            }
        }

        /// <summary>
        /// La connexion SQLServer courrante. Utiliser <see cref="Connecter"/> pour se connecter (lecture seule).
        /// </summary>
        public static SqlConnection Connexion { get; private set; } = null;
        
        static BDD()
        {
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
    }
}