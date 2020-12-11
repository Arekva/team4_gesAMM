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
        }

        private void CbMedocs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Medicament medoc = medocs[cbMedocs.SelectedItem.ToString()];//Globale.Medicaments[cbMedocs.SelectedItem.ToString()];


            if (medoc.getDerniereEtape() == null)
            {
                ListViewItem aa = new ListViewItem();

                aa.Text = Globale.Etapes[1].getNumero().ToString();
                aa.SubItems.Add("En cours");
                aa.SubItems.Add(Globale.Etapes[1].getLibelle());
                aa.SubItems.Add("Aucune");
                aa.SubItems.Add("Aucune");
                aa.SubItems.Add("En cours");

                lvWorkFlow.Items.Add(aa);
            }
            else if  (Globale.Decisions[medoc.getDerniereEtape().getidDecision()].getID() == 2)
            {
                MessageBox.Show("La dernière étape du médicament est refusée. Aucune autre étape ne peut être ajoutée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                





            }



        }
    }
}
