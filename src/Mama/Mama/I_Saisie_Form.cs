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

        Dictionary<string, Medicament> medocs = new Dictionary<string, Medicament>();
        

        private void I_Saisie_Form_Load(object sender, EventArgs e)
        {

            foreach(var kvp in Globale.Medicaments)
            {
                medocs.Add(kvp.Value.getNomCommercial(), kvp.Value);
                cbMedocs.Items.Add(kvp.Value.getNomCommercial());
            }

            cbMedocs.SelectedIndexChanged += CbMedocs_SelectedIndexChanged;
            btValider.Enabled = false;
            btRefuser.Enabled = false;

        }

        private void RemplirEtapeFinis(Medicament medoc)
        {
            foreach (Subir letape in medoc.getLeWorkflow())
            {
                ListViewItem aa = new ListViewItem();

                aa.Text = letape.getEtape().getNumero().ToString();
                aa.SubItems.Add(letape.getDateDecision().ToString());
                aa.SubItems.Add(letape.getEtape().getLibelle());
                if (letape.getEtape().GetType().ToString() == "EtapeNormee")
                {
                    aa.SubItems.Add((letape.getEtape() as EtapeNormee).getNorme());
                    aa.SubItems.Add((letape.getEtape() as EtapeNormee).getDate().ToString());
                }
                else
                {
                    aa.SubItems.Add("Aucune");
                    aa.SubItems.Add("Aucune");
                }
                if (letape.getidDecision() == 1)
                {
                    aa.SubItems.Add("Validé");
                }
                else { aa.SubItems.Add("Refusé"); }


                lvWorkFlow.Items.Add(aa);
            }
        }
        private void mettreEtapeEnCours(Medicament medoc)
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
        {
            Medicament medoc = medocs[cbMedocs.SelectedItem.ToString()];//Globale.Medicaments[cbMedocs.SelectedItem.ToString()];
            lvWorkFlow.Items.Clear();


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
        {
            Medicament medoc = medocs[cbMedocs.SelectedItem.ToString()];


            Subir NewSubission = new Subir(dtpDate.Value, Globale.Etapes[medoc.getLeWorkflow().Count + 1], idDecision, medoc.getDepotLegal());
            Globale.Workflow.Add(NewSubission);
            medocs[cbMedocs.SelectedItem.ToString()].addToWorkflow(NewSubission);

            BDD.LireProcedure("prc_newWorkflow", new Parametre("@dateDeci", dtpDate.Value, 50),
                new Parametre("@numEtape", NewSubission.getEtape().getNumero(), 50),
                new Parametre("@idDeci", NewSubission.getidDecision(), 50),
                new Parametre("@depotLegal", NewSubission.getCodeDepot(), 250));

            Globale.Medicaments[medoc.getDepotLegal()].setDerniereEtape(NewSubission.getEtape().getNumero());
            updateListView();
            if (idDecision == 1 && medocs[cbMedocs.SelectedItem.ToString()].getLeWorkflow().Count == 8)
            {
                Random r = new Random();
                BDD.LireProcedure("prc_setAMM", new Parametre("@amm",r.Next(0,9999999), 50),
               new Parametre("@depot", NewSubission.getCodeDepot(), 50));
            }
            BDD.LireProcedure("prc_setLastEtape", new Parametre("@depot", NewSubission.getCodeDepot(), 50),
               new Parametre("@etape", NewSubission.getEtape().getNumero(), 10));

        }

        private void btRefuser_Click(object sender, EventArgs e)
        {
            AccepterOuRefuser(2);
        }
    }
}
