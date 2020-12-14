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
    public partial class C_Workflow_Form : Form
    {
        public C_Workflow_Form()
        {
            InitializeComponent();
        }

        private void C_Workflow_Form_Load(object sender, EventArgs e)
        {
            foreach(Medicament medoc in Globale.Medicaments.Values)
            {
                cbMedocs.Items.Add(medoc.getNomCommercial());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMedocs.Text == "Aucune") MessageBox.Show("Veuillez selectionner un médicament");
            else
            {
                Medicament medicament = Globale.Medicaments.Where(m => m.Value.getNomCommercial() == cbMedocs.Text).FirstOrDefault().Value;

                lvWF.Items.Clear();

                foreach(Subir sub in medicament.getLeWorkflow())
                {
                    Etape etp = sub.getEtape();
                    ListViewItem lvi = new ListViewItem(etp.getNumero().ToString());
                    lvi.SubItems.Add(etp.getLibelle());
                    lvi.SubItems.Add(sub.getDateDecision().ToShortDateString());

                    if(etp is EtapeNormee en)
                    {
                        lvi.SubItems.Add(en.getNorme());
                        lvi.SubItems.Add(en.getDate().ToShortDateString());
                    }

                    lvWF.Items.Add(lvi);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
