using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mama
{
    class Medicament
    {
        private string depotLegal; // clé primaire
        private string nomCommercial;
        private string composition;
        private string effets;
        private string contreIndication;
        private string AMM; //code de l'autorisation de la mise en marché est null si le medoc n'est pas autoriser
                            //NULL A SA CREATION
        private Etape DerniereEtape; //il s'agit de la derniere étape de test effectuer 
                                     //NULL A SA CREATION
        private Famille laFamille; // la famille du medicament


        public Medicament(string leDepot, string leNomCommercial, string laComposition, string leEffet,
            string laContreIndication, Famille laaFamille)
        {
            this.depotLegal = leDepot;
            this.nomCommercial = leNomCommercial;
            this.composition = laComposition;
            this.effets = leEffet;
            this.contreIndication = laContreIndication;
            this.laFamille = laaFamille;
            this.AMM = null;
            this.DerniereEtape = null;
        }

        private string getDepotLogal() { return this.depotLegal; }
        private string getNomCommercial() { return this.nomCommercial; }
        private string getComposition() { return this.composition; }
        private string getContreIndication() { return this.contreIndication; }
        private string getAMM() { return this.AMM; }
        private Etape getDerniereEtape() { return this.DerniereEtape; }
        private Famille getFamille() { return this.laFamille; }


        private void setDepotLogal(string leCode) { this.depotLegal = leCode; }
        private void setNomCommercial(string leNom) { this.nomCommercial = leNom; }
        private void setComposition(string laCompo) { this.composition= laCompo; }
        private void setContreIndication(string lindication) { this.contreIndication = lindication; }
        private void setAMM(string laAMM) { this.AMM = laAMM; }
        private void setDerniereEtape(Etape lEtape) { this.DerniereEtape = lEtape; }
        private void setFamille(Famille laNewFamille) { this.laFamille = laNewFamille; }



    }
}
