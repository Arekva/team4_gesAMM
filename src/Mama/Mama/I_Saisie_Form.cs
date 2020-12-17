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
    public partial class I_Saisie_Form : Form
    {
        public I_Saisie_Form()
        {
            InitializeComponent();
        }
        // Initialisation d'une liste de médicaments
        Dictionary<string, Medicament> medocs = new Dictionary<string, Medicament>();
        

        private void I_Saisie_Form_Load(object sender, EventArgs e)
        {

            foreach(string laCle in Globale.Medicaments.Keys)
            {
                medocs.Add(Globale.Medicaments[laCle].getNomCommercial(), Globale.Medicaments[laCle]);
                //Remplissage de la liste de médicament temporaire MAIS avec le nom commercial en tant que clé
                cbMedocs.Items.Add(Globale.Medicaments[laCle].getNomCommercial());
            }

            cbMedocs.SelectedIndexChanged += CbMedocs_SelectedIndexChanged;
            //quand l'index de la comboBox, execute "cbMedocs_SelectedIndexChanged";

            btValider.Enabled = false;
            btRefuser.Enabled = false;
            nudAMM.Enabled = false;

        }

        private void RemplirEtapeFinis(Medicament medoc)
            //C'est la fonction qui rajoute les étapes qui sont validée ou refusée dans la listeView
        {
            foreach (Subir letape in medoc.getLeWorkflow())
            {
                ListViewItem aa = new ListViewItem();

                aa.Text = letape.getEtape().getNumero().ToString();
                aa.SubItems.Add(letape.getDateDecision().ToShortDateString());
                aa.SubItems.Add(letape.getEtape().getLibelle());
                if (letape.getEtape().GetType().ToString() == "Mama.EtapeNormee")
                {
                    aa.SubItems.Add((letape.getEtape() as EtapeNormee).getNorme());
                    aa.SubItems.Add((letape.getEtape() as EtapeNormee).getDate().ToShortDateString());
                }
                else
                {
                    aa.SubItems.Add("Aucune");
                    aa.SubItems.Add("Aucune");
                }

                aa.SubItems.Add(Globale.Decisions[letape.getidDecision()].getLibelle());



                lvWorkFlow.Items.Add(aa);
            }
        }
        private void mettreEtapeEnCours(Medicament medoc)
            //C'est la fonction qui met l'etape en cours, celle ou l'on choisit si elle est validee ou refusee
        {
            ListViewItem aa = new ListViewItem();

            aa.Text = Globale.Etapes[medoc.getLeWorkflow().Count + 1].getNumero().ToString();
            aa.SubItems.Add("En cours");
            aa.SubItems.Add(Globale.Etapes[medoc.getLeWorkflow().Count + 1].getLibelle());
            aa.SubItems.Add("Aucune");
            aa.SubItems.Add("Aucune");
            aa.SubItems.Add("En cours");

            lvWorkFlow.Items.Add(aa);
        }

        private void updateListView()
            //C'est la fonction qui utilise celles vue précedement pour constituer la listeview
        {
            Medicament medoc = medocs[cbMedocs.SelectedItem.ToString()]; // c'est la qu'on voit l'interet du dictionnaire avec le nom commerciale
            if (medoc.getLeWorkflow().Count == 7)
            {
                MessageBox.Show("Il s'agit de la derniere étape, veuillez saisir un numéro AMM pour valider l'autorisation sur la mise en marché",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nudAMM.Enabled = true;
            }
            else
            {
                nudAMM.Enabled = false;
            }

            if (medoc.getDerniereEtape() == null)
            {
                mettreEtapeEnCours(medoc);
                btValider.Enabled = true;
                btRefuser.Enabled = true;

            }
            else if (medoc.getLeWorkflow()[medoc.getLeWorkflow().Count - 1].getidDecision() == 2)
            {
                MessageBox.Show("La dernière étape du médicament est refusée. Aucune autre étape ne peut être ajoutée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RemplirEtapeFinis(medoc);
                btValider.Enabled = false;
                btRefuser.Enabled = false;

            }
            else
            {
                RemplirEtapeFinis(medoc);
                if (medoc.getLeWorkflow().Count != 8) { 
                mettreEtapeEnCours(medoc);
                btValider.Enabled = true;
                btRefuser.Enabled = true;
                                                         }
                else
                {
                    btValider.Enabled = false;
                    btRefuser.Enabled = false;
                }
            }
        }
        private void CbMedocs_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            updateListView();

        }

        private void btValider_Click(object sender, EventArgs e)
        {
            AccepterOuRefuser(1);

        }

        private void AccepterOuRefuser(int idDecision)
            //Action en cas d'appuis sur le bouton valider ou refuser
        {
            Medicament medoc = medocs[cbMedocs.SelectedItem.ToString()];


            Subir NewSubission = new Subir(dtpDate.Value, Globale.Etapes[medoc.getLeWorkflow().Count + 1], idDecision, medoc.getDepotLegal());
            Globale.Workflow.Add(NewSubission);
            medocs[cbMedocs.SelectedItem.ToString()].addToWorkflow(NewSubission);
            //ajout de la ligne du workflow dans l'application

            BDD.LireProcedure("prc_newWorkflow", new Parametre("@dateDeci", dtpDate.Value, 50),
                new Parametre("@numEtape", NewSubission.getEtape().getNumero(), 50),
                new Parametre("@idDeci", NewSubission.getidDecision(), 50),
                new Parametre("@depotLegal", NewSubission.getCodeDepot(), 250));
            //ajout de la ligne du workflow dans la bdd

            Globale.Medicaments[medoc.getDepotLegal()].setDerniereEtape(NewSubission.getEtape().getNumero());
            updateListView();
            //ajout de la derniere étape du médicament dans l'application
            if (idDecision == 1 && medocs[cbMedocs.SelectedItem.ToString()].getLeWorkflow().Count == 8)
            {
               BDD.LireProcedure("prc_setAMM", new Parametre("@amm",(int)nudAMM.Value, 50),
               new Parametre("@depot", NewSubission.getCodeDepot(), 50));
                //ajout de la derniere étape dans la bdd
                MessageBox.Show("Le medicament " + medoc.getNomCommercial() + " a été valider avec le numéro AMM : " + (int)nudAMM.Value, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btRefuser_Click(object sender, EventArgs e)
        {
            AccepterOuRefuser(2);
        }
    }
}
