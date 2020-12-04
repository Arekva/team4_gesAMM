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

        private void I_Saisie_Form_Load(object sender, EventArgs e)
        {
            foreach(var kvp in Globale.Medicaments)
            {
                cbMedocs.Items.Add(kvp.Value.getNomCommercial());
            }

            cbMedocs.SelectedIndexChanged += CbMedocs_SelectedIndexChanged;
        }

        private void CbMedocs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Medicament medoc = Globale.Medicaments[cbMedocs.SelectedItem.ToString()];
            
            if(medoc.getDerniereEtape() == null || Globale.Decisions[medoc.getDerniereEtape().getidDecision()].getID() == 2)
            {
                MessageBox.Show("La dernière étape du médicament est refusée. Aucune autre étape ne peut être ajoutée.");
            }
        }
    }
}
