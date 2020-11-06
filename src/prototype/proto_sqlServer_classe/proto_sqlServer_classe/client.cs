using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace proto_sqlServer_classe
{
    class client
    {
        private int id;
        private string nom;
        private List<facture> lesFactures;

        public client(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
            this.lesFactures = new List<facture>();
        }

        public int getId() { return this.id; }
        public string getNom() { return this.nom; }
        public List<facture> getLesFactures() { return this.lesFactures; }
        public void ajouterFacture(facture laFacture)
        {
            this.lesFactures.Add(laFacture);
        }
    }
}
