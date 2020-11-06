using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proto_sqlServer_classe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bd.lireLesClientsAvecFactures();
            foreach (client leClient in globale.lesClients)
            {
                foreach (facture laFacture in leClient.getLesFactures())
                {
                    ListViewItem maLigne = new ListViewItem();
                    maLigne.Text = leClient.getNom();
                    maLigne.SubItems.Add(laFacture.getNumFact().ToString());
                    maLigne.SubItems.Add(laFacture.getDateFact().ToShortDateString());
                    maLigne.SubItems.Add(laFacture.getMtFact().ToString());
                    lstClients.Items.Add(maLigne);
                }
            }
        }
    }
}
