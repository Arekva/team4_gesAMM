using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mama
{
    public partial class btValider : Form
    {
        public btValider()
        {
            InitializeComponent();
        }

        private void I_Ajout_Form_Load(object sender, EventArgs e)
        {
            foreach (string laClef in Globale.Familles.Keys)
            {
                cbFamille.Items.Add(Globale.Familles[laClef].getLibelle());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Globale.Medicaments.Keys.Contains(tbDepotLegal.Text.ToUpper()))
            {
                MessageBox.Show("Erreur, le dépot legal existe déja");
            }
            else
            {
                int i = 0;
                bool trouv = false;
                string laClefFamille = null;
                while (trouv == false && i < Globale.Familles.Count()){
                    if (Globale.Familles.ElementAt(i).Value.getLibelle() == cbFamille.Text )
                    {
                        trouv = true;
                        laClefFamille = Globale.Familles.ElementAt(i).Value.getCode();


                    }
                    else { i++; }
                }

                Medicament leMedoc = new Medicament(tbDepotLegal.Text.ToUpper(), tbNomCommerciale.Text, tbCompostion.Text, tbEffets.Text, tbContreIndication.Text, Globale.Familles[laClefFamille]);
                Globale.Medicaments.Add(tbDepotLegal.Text.ToUpper(), leMedoc);
                BDD.LireProcedure("prc_nouveau_medicament", new Parametre("@depotLegal",tbDepotLegal.Text,50),
                    new Parametre("@nomCommerciale", tbNomCommerciale.Text, 50),
                    new Parametre("@composition", tbCompostion.Text, 255), 
                    new Parametre("@effet", tbEffets.Text, 255), 
                    new Parametre("@contreIndication", tbContreIndication.Text, 255), 
                    new Parametre("@codeFamille",laClefFamille, 50));
                MessageBox.Show("Succés", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
