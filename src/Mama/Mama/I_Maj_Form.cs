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
                if (Globale.Etapes[laClef] is EtapeNormee norme)
                {
                    ListViewItem lvi = new ListViewItem();

                    lvi.Text = norme.getNumero().ToString();
                    lvi.SubItems.Add(norme.getLibelle());
                    lvi.SubItems.Add(norme.getDate().ToShortDateString());
                    lvi.SubItems.Add(norme.getNorme());


                    lvEtape.Items.Add(lvi);
                }
                
            }
        }

        int selectedIdx = -1 ;
        private void lvEtape_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedIdx = int.Parse(lvEtape.FocusedItem.Text);
            tbDateNorme.Text = (Globale.Etapes[selectedIdx] as EtapeNormee).getDate().ToShortDateString();
            tbNorme.Text = (Globale.Etapes[selectedIdx] as EtapeNormee).getNorme();
        }

        private void btEnregistrerNorme_Click(object sender, EventArgs e)
        {
            DateTime dateValue;
            if (DateTime.TryParse(tbDateNorme.Text, out dateValue))
                Console.WriteLine("  Converted '{0}' to {1} ({2}).", tbDateNorme.Text,
                                  dateValue, dateValue.Kind);
            else
                Console.WriteLine("  Unable to parse '{0}'.", tbDateNorme.Text);
        }
    }
}
