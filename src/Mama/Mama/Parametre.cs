using System;
using System.Data;
using System.Security.AccessControl;
using SqlT = System.Data.SqlDbType;

namespace Mama
{
    /// <summary>
    /// Structure de paramètre de procédure.
    /// </summary>
    public struct Parametre
    {
        /// <summary>
        /// La valeur du paramètre.
        /// </summary>
        public object Valeur { get; }
        /// <summary>
        /// Le type SQL du paramètre (déterminé automatiquement)
        /// </summary>
        public SqlT TypeSQL { get; }
        /// <summary>
        /// Le nom dans la procédure (ex: @idFamille)
        /// </summary>
        public string NomSQL { get; }
        /// <summary>
        /// La taille du paramètre SQL.
        /// </summary>
        public int Taille { get; }

        /// <summary>
        /// Créer un paramètre de procédure stoquée avec un objet C#.
        /// </summary>
        /// <param name="nomParametre">Le nom dans la procédure (ex: @idFamille)</param>
        /// <param name="valeur">La valeur du paramètre.</param>
        /// <param name="taille">La taille du paramètre (ex: varchar de 50)</param>
        public Parametre(string nomParametre, object valeur, int taille, SqlT? type = null)
        {
            this.NomSQL = nomParametre;
            this.Valeur = valeur;
            this.Taille = taille;

            if (type == null)
            {
                if (valeur is string) TypeSQL = SqlT.Char;
                else if (valeur is int) TypeSQL = SqlT.Int;
                else if (valeur is decimal) TypeSQL = SqlT.Money;
                else if (valeur is DateTime) TypeSQL = SqlT.DateTime;
                else // si y'a aucun type correspondant, char par defaut
                {
                    TypeSQL = SqlT.Char;
                    this.Valeur = valeur.ToString();
                }
            }
            else
            {
                TypeSQL = type.Value;
                this.Valeur = valeur.ToString();
            }
        }
    }
}