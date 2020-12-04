﻿using System;
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
    public partial class I_Ajout_Form : Form
    {
        public I_Ajout_Form()
        {
            InitializeComponent();
        }

        private void I_Ajout_Form_Load(object sender, EventArgs e)
        {
            foreach (string laClef in Globale.Familles.Keys)
            {
                cbFamille.Items.Add(Globale.Familles[laClef].getLibelle());
            }
        }
    }
}
