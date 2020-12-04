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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void médicamentsEnCoursDeValidationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C_MedicamentsEnCours_Form laForm = new C_MedicamentsEnCours_Form;
            laForm.MdiParent = this;
            laForm.Show();
        }

        private void ajoutDunNouveauMédicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            I_Ajout_Form laForm = new I_Ajout_Form();
            laForm.MdiParent = this;
            laForm.Show();
        }

        private void miseÀJourDesÉtapesNorméesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            I_Maj_Form laForm = new I_Maj_Form();
            laForm.MdiParent = this;
            laForm.Show();
        }

        private void saisieDeLaDécisionDuneÉtapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            I_Saisie_Form laForm = new I_Saisie_Form();
            laForm.MdiParent = this;
            laForm.Show();
        }
    }
}
