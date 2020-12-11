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


            test();

        }
        private void test()
        {
            lbTest.Items.Clear();
            foreach (Subir leSubir in Globale.Workflow)
            {
                lbTest.Items.Add(leSubir.getCodeDepot());
            }
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

            }
            else if (medoc.getLeWorkflow()[medoc.getLeWorkflow().Count - 1].getidDecision() == 2)
            {
                MessageBox.Show("La dernière étape du médicament est refusée. Aucune autre étape ne peut être ajoutée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RemplirEtapeFinis(medoc);


            }
            else
            {
                RemplirEtapeFinis(medoc);
                mettreEtapeEnCours(medoc);

            }
        }
        private void CbMedocs_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateListView();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            Medicament medoc = medocs[cbMedocs.SelectedItem.ToString()];

                Subir NewSubission = new Subir(dtpDate.Value, Globale.Etapes[medoc.getLeWorkflow().Count + 1], 1, medoc.getDepotLegal());
                Globale.Workflow.Add(NewSubission);
                medocs[cbMedocs.SelectedItem.ToString()].addToWorkflow(NewSubission);


                Globale.Medicaments[medoc.getDepotLegal()].setDerniereEtape(NewSubission.getEtape().getNumero());
                test();
                updateListView();



        }
    }
}
