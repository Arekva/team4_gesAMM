using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mama
{
    class Subir
    {
        private DateTime dateDecision;
        private Etape lEtape;
        private int idDecision;
        private string codeDepotLegal;


        public Subir(DateTime ladecision, Etape laEtape,int lidDecision,string leCodeDepotLegal)
        {
            this.dateDecision = ladecision;
            this.lEtape = laEtape;
            this.idDecision = lidDecision;
            this.codeDepotLegal = leCodeDepotLegal;
        }

        //get

        public DateTime getDateDecision() { return this.dateDecision; }
        public Etape getEtape() { return this.lEtape; }
        public int getidDecision() { return this.idDecision; }
        public string getCodeDepot() { return this.codeDepotLegal; }

        //set

        public void setDateDecision(DateTime date) { this.dateDecision = date; }
        public void setEtape(Etape etape) { this.lEtape = etape; }
        public void setidDecision(int id) { this.idDecision = id; }
        public void setCodeDepot(string code) { this.codeDepotLegal = code; }

    }


    









}
