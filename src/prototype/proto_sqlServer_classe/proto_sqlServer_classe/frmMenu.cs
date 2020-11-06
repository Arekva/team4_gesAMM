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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //Connexion à la base de données
            globale.cnx = new System.Data.SqlClient.SqlConnection();
            globale.cnx.ConnectionString = "Data Source=HPG6-04\\SQLEXPRESS;Initial Catalog=proto_classe;Integrated Security=True;MultipleActiveResultSets=True";
            globale.cnx.Open();

            globale.lesClients = new List <client>();
            
        }

        private void afficherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newFrm = new Form1();
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void afficherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 newFrm = new Form2();
            newFrm.MdiParent = this;
            newFrm.Show();
        }
    }
}
