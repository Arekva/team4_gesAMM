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
    public partial class I_Maj_Form : Form
    {
        public I_Maj_Form()
        {
            InitializeComponent();
        }

        private void I_Maj_Form_Load(object sender, EventArgs e)
        {
            foreach(int laClef in Globale.Etapes.Keys)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Text = Globale.Etapes[laClef].getNumero().ToString();
                lvi.SubItems.Add(Globale.Etapes[laClef].getLibelle());
                

                lvEtape.Items.Add(lvi);
            }
        }
    }
}
