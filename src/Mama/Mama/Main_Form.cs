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
        int userId;
        public Main_Form(int UserKey)
        {
            InitializeComponent();
            int WScreen = Screen.PrimaryScreen.Bounds.Width;
            int HScreen = Screen.PrimaryScreen.Bounds.Height;
            this.Size = new Size(WScreen,HScreen);
            userId = UserKey;
        }
        


        private void ajoutDunNouveauMédicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btValider laForm = new btValider();
            laForm.MdiParent = this;
            laForm.Show();
        }

        private void miseÀJourDesÉtapesNorméesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            I_Maj_Form laForm = new I_Maj_Form(userId);
            laForm.MdiParent = this;
            laForm.Show();
        }

        private void saisieDeLaDécisionDuneÉtapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            I_Saisie_Form laForm = new I_Saisie_Form();
            laForm.MdiParent = this;
            laForm.Show();
        }

        private void workflowDesÉtapesDunMédicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C_Workflow_Form laForm = new C_Workflow_Form();
            laForm.MdiParent = this;
            laForm.Show();
        }

        private void nombreDeMédicamentsAutorisésParFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C_NombreMedicaments_Form laForm = new C_NombreMedicaments_Form();
            laForm.MdiParent = this;
            laForm.Show();
        }        
        
        private void médicamentsEnCoursDeValidationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C_MedicamentsEnCours_Form laForm = new C_MedicamentsEnCours_Form();
            laForm.MdiParent = this;
            laForm.Show();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            //test pour afficher l'id de l'utilisateur avec lequel on se connect
            MessageBox.Show(this.userId.ToString());
        }
    }
}
