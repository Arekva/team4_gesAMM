using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mama
{
    public class EtapeNormee : Etape
    {
        public EtapeNormee(int num, string libelle, string norme, DateTime date, int? user) : base(num,libelle)
        {
            this._Norme = norme;
            this._Date = date;
            this._IdUser = user;
        }

        private string _Norme = null;
        private DateTime _Date;
        private int? _IdUser;

        public string getNorme()
        {
            return this._Norme;
        }

        public DateTime getDate()
        {
            return this._Date;
        }

        public void setNorme(string norme)
        {
            this._Norme = norme;
        }

        public void setDate(DateTime date)
        {
            this._Date = date;
        }

        public void setUser(int? user)
        {
            this._IdUser = user;
        }
    }
}
