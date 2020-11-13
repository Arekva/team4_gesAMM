namespace Mama
{
    public class Decision
    {
        public Decision(int id, string libelle)
        {
            this._ID = id;
            this._Libelle = libelle;
        }

        private int _ID;
        private string _Libelle;

        public int getID()
        {
            return this._ID;
        }

        public string getLibelle()
        {
            return this._Libelle;
        }
    }
}