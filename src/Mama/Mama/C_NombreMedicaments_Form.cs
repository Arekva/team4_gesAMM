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

        private string codeFamille = "";



        private void C_NombreMedicaments_Form_Load(object sender, EventArgs e)
        {
            this.MinimumSize = Parent.Size;
            foreach (string laClef in Globale.Familles.Keys)
            {
                ListViewItem lvi = new ListViewItem();
                
                lvi.Text = Globale.Familles[laClef].getCode();
                lvi.SubItems.Add(Globale.Familles[laClef].getLibelle());
                lvi.SubItems.Add(Globale.Familles[laClef].getNombreAMM().ToString());

                lvFamille.Items.Add(lvi);
            }
        }
        

        private void lvFamille_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            tbFamilleSelection.Text = lvFamille.FocusedItem.Text;
            codeFamille = lvFamille.FocusedItem.Text;
        }

        private void btChercherMedicament_Click(object sender, EventArgs e)
        {
            if (tbFamilleSelection.Text == "Aucune") MessageBox.Show("Veuillez selectionner une famille");
            else
            {
                lvLesMedicaments.Items.Clear();
                foreach (string laClef in Globale.Medicaments.Keys)
                {
                    if (Globale.Medicaments[laClef].getFamille().getCode() == codeFamille && Globale.Medicaments[laClef].getAMM() != "")
                    {
                        ListViewItem lvi = new ListViewItem();

                        lvi.Text = Globale.Medicaments[laClef].getNomCommercial();

                        lvLesMedicaments.Items.Add(lvi);
                    }
                }
            }
        }
    }
}
