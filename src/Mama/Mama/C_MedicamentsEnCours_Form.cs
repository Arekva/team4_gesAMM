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
    public partial class C_MedicamentsEnCours_Form : Form
    {
        private IEnumerable<Medicament> _medicaments;


        public C_MedicamentsEnCours_Form()
        {
            InitializeComponent();
        }

        private void C_MedicamentsEnCours_Form_Load(object sender, EventArgs e)
        {
            _medicaments = Globale.Medicaments.Values.
                Where(m => m.getLeWorkflow().Count() == 0 || (m.getAMM() == null && m.getLeWorkflow().Last().getidDecision() != 2));
            foreach (Medicament medoc in _medicaments)
            {
                ListViewItem lvi = new ListViewItem(medoc.getNomCommercial());
                lvi.SubItems.Add(medoc.getFamille().getLibelle());
                this.lvMedocs.Items.Add(lvi);
            }
        }

        private void lvMedocs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMedocs.SelectedIndices.Count == 0) return;

            Medicament medoc = _medicaments.ElementAt(lvMedocs.SelectedIndices[0]);

            lvWorkflow.Items.Clear();

            foreach(Subir sub in medoc.getLeWorkflow())
            {
                ListViewItem lvi = new ListViewItem(sub.getEtape().getNumero().ToString());
                lvi.SubItems.Add(sub.getEtape().getLibelle());

                Decision dec = Globale.Decisions[sub.getidDecision()];

                lvi.SubItems.Add(dec.getLibelle());

                lvWorkflow.Items.Add(lvi);
            }

            lvWorkflow.Enabled = true;
        }
    }
}
