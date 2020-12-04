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

        }

        private void ajoutDunNouveauMédicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            I_Ajout_Form laForm = new I_Ajout_Form();
            laForm.Show();
        }
    }
}
