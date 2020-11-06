using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proto_sqlServer_classe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chargerListe()
        {
            lstClients.Items.Clear();

            bd.lireLesClientsAlpha();
            
            foreach (client leClient in globale.lesClients)
            {
                ListViewItem maLigne = new ListViewItem();
                maLigne.Text = leClient.getId().ToString();
                maLigne.SubItems.Add(leClient.getNom());
                lstClients.Items.Add(maLigne);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chargerListe();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtNom.Text != "")
            {
                try
                {
                    int idx = int.Parse(txtId.Text.Trim());
                    if (bd.ajouterClient(idx, txtNom.Text))
                    {
                        MessageBox.Show("Le client a bien été ajouté");
                        chargerListe();
                    }
                    else
                    { 
                        MessageBox.Show("Erreur dans l'ajout du client");
                    }
                }
                catch
                {
                    MessageBox.Show("Erreur, le n° de client doit être un entier");
                }
            }
            else
            {
                MessageBox.Show("Erreur, il faut renseigner tous les champs");
            }
        }
    }
}
