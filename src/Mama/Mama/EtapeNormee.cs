using System;

namespace Mama
{
    /// <summary>
    /// Variante d'une étape possédant une norme.
    /// </summary>
    public class EtapeNormee : Etape
    {
        /// <summary>
        /// La norme.
        /// </summary>
        public string Norme { get; } = null;
        /// <summary>
        /// La date.
        /// </summary>
        public DateTime Date { get; }

        /// <summary>
        /// Étape de validation de médicament. Une norme est aussi appliquée.
        /// </summary>
        /// <param name="num">Le numéro identifiant.</param>
        /// <param name="libelle">Le libellé de l'étape.</param>
        /// <param name="norme">Le libellé de la norme.</param>
        /// <param name="date">La date où la norme à été appliquée.</param>
        public EtapeNormee(int num, string libelle, string norme, DateTime date) : base(num, libelle)
        {
            this.Norme = norme;
            this.Date = date;
        }
    }
}