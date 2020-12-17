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
        int idUser;
        public I_Maj_Form(int user)
        {
            InitializeComponent();
            idUser = user;
        }

        private void I_Maj_Form_Load(object sender, EventArgs e)
        {
            loadingView();
            this.MinimumSize = Parent.Size;
        }

        public void loadingView()
        {
            lvEtape.Items.Clear();
            tbNorme.Clear();
            tbDateNorme.Clear();
            foreach (int laClef in Globale.Etapes.Keys)
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
            /*
            // test permettant que voir si on arrive à convertir une date
            DateTime dateValue;
            if (DateTime.TryParse(tbDateNorme.Text, out dateValue))
                Console.WriteLine("  Converted '{0}' to {1} ({2}).", tbDateNorme.Text,
                                  dateValue, dateValue.Kind);
            else
                Console.WriteLine("  Unable to parse '{0}'.", tbDateNorme.Text);
            */
            if(selectedIdx == -1)
            {
                MessageBox.Show("Veuillez selectioner une étape normée");
            }
            else
            {
                DateTime testDateConvert;
                if (DateTime.TryParse(tbDateNorme.Text, out testDateConvert))
                {
                    string laDateNorme = testDateConvert.ToString("d");
                    if(tbNorme.TextLength == 12)
                    {
                        (Globale.Etapes[selectedIdx] as EtapeNormee).setNorme(tbNorme.Text);
                        (Globale.Etapes[selectedIdx] as EtapeNormee).setDate(testDateConvert);
                        (Globale.Etapes[selectedIdx] as EtapeNormee).setUser(idUser);
                        string manorme = tbNorme.Text;
                        BDD.LireProcedure("prc_maj_etapes_normee", 
                        new Parametre("@numEtape", selectedIdx, 32),
                        new Parametre("@norme", manorme, 30, SqlDbType.Char),
                        new Parametre("@dateNorme", testDateConvert, 50),
                        new Parametre("@idUser", idUser, 50));
                        loadingView();
                    }
                    else
                    {
                        MessageBox.Show("Entrez une norme valide");
                    }
                }
                else
                    MessageBox.Show("  Unable to parse "+ tbDateNorme.Text + "\n Entrez une date valide" );
            }

        }


    }
}
