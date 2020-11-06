using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace proto_sqlServer_classe
{
    class facture
    {
        private int numFact;
        private DateTime dateFact;
        private double mtFact;
        private int numClient;

        public facture(int numFact, DateTime dateFact, double mtFact, int numClient)
        {
            this.numFact = numFact;
            this.dateFact = dateFact;
            this.mtFact = mtFact;
            this.numClient = numClient;
        }

        public int getNumFact() { return this.numFact ; }
        public DateTime getDateFact() { return this.dateFact; }
        public double getMtFact() { return this.mtFact; }
        public int getNumClient() { return this.numClient; }
    }
}
