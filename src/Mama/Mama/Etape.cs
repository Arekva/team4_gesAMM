namespace Mama
{
    /// <summary>
    /// Étape de validation de médicament.
    /// </summary>
    public class Etape
    {
        /// <summary>
        /// Le numéro (ETP_num) d'étape.
        /// </summary>
        public int Numero { get; } = 0;
        /// <summary>
        /// Le libellé (ETP_libelle) de l'étape.
        /// </summary>
        public string Libelle { get; } = null;
        
        /// <summary>
        /// Étape de validation de médicament.
        /// </summary>
        /// <param name="num">Le numéro identifiant.</param>
        /// <param name="libelle">Le libellé du médicament.</param>
        public Etape(int num, string libelle)
        {
            Numero = num;
            Libelle = libelle;
        }
    }
}