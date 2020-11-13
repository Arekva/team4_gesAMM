using System;

namespace Mama
{
    /// <summary>
    /// Étape de validation de médicament.
    /// </summary>
    public class Etape
    {
        /// <summary>
        /// Étape de validation de médicament. Une norme est aussi appliquée.
        /// </summary>
        /// <param name="num">Le numéro identifiant.</param>
        /// <param name="libelle">Le libellé de l'étape.</param>
        /// <param name="norme">Le libellé de la norme.</param>
        /// <param name="date">La date où la norme à été appliquée.</param>
        public Etape(int num, string libelle, string norme, DateTime date)
        {
            this._Numero = num;
            this._Libelle = libelle;
            this._Norme = norme;
            this._Date = date;
        }
        

        private int _Numero = 0;
        private string _Libelle = null;
        private string _Norme = null;
        private DateTime _Date;


        public int getNumero()
        {
            return this._Numero;
        }

        public string getLibelle()
        {
            return this._Libelle;
        }

        public string getNorme()
        {
            return this._Norme;
        }

        public DateTime getDate()
        {
            return this._Date;
        }
        
        
        
    }
}