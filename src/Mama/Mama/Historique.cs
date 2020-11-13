using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mama
{
    class Historique
    {
        private int numero;
        private DateTime dateMiseAJour;
        private int idUser;
        private Etape lEtape;
        private string oldNorme;
        private string newNorme;
        private DateTime dateOldNorme;
        private DateTime dateNewNorme;


        public Historique(int leNumero, DateTime laDateMiseAJour, int lIdUser, Etape laEtape, string laOldNorme,
            string laNewNorme, DateTime laDateOldNorme, DateTime laDateNewNorme)
        {
            numero = leNumero;
            dateMiseAJour = laDateMiseAJour;
            idUser = lIdUser;
            lEtape = laEtape;
            oldNorme = laOldNorme;
            newNorme = laNewNorme;
            dateOldNorme = laDateOldNorme;
            dateNewNorme = laDateNewNorme;
        }

        public int getNumero() { return this.numero; }
        public DateTime getDateMiseAJour() { return this.dateMiseAJour; }
        public int getIdUser() { return this.idUser; }
        public Etape getLEtape() { return this.lEtape; }
        public string getOldNorme() { return this.oldNorme; }
        public string getNewNorme() { return this.newNorme; }
        public DateTime getDateOldNorme() { return this.dateOldNorme; }
        public DateTime getDateNewNorme() { return this.dateNewNorme; }


        public void setNumero(int leNumero) {  this.numero= leNumero ; }
        public void setDateMiseAJour(DateTime laDate) {  this.dateMiseAJour= laDate; }
        public void setIdUser(int leID) {  this.idUser = leID; }
        public void setLEtape(Etape laEtape) {  this.lEtape = laEtape; }
        public void setOldNorme(string LancienneNorme) {  this.oldNorme= LancienneNorme; }
        public void setNewNorme(string NouvelleNorme) {  this.newNorme= NouvelleNorme; }
        public void setDateOldNorme(DateTime lAncienneDate) {  this.dateOldNorme = lAncienneDate; }
        public void setDateNewNormeDateTime(DateTime LaNouvelleDate) {  this.dateNewNorme= LaNouvelleDate; }






    }
}
