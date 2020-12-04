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
    public partial class C_NombreMedicaments_Form : Form
    {
        public C_NombreMedicaments_Form()
        {
            InitializeComponent();
        }

        private void C_NombreMedicaments_Form_Load(object sender, EventArgs e)
        {
            
            foreach (string laClef in Globale.Familles.Keys)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Text = Globale.Familles[laClef].getCode();
                lvi.SubItems.Add(Globale.Familles[laClef].getLibelle());
                lvi.SubItems.Add(Globale.Familles[laClef].getNombreAMM().ToString());

                lvFamille.Items.Add(lvi);
            }
        }
    }
}
