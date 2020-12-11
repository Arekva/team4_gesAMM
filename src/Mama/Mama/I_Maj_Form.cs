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
                    lvi.SubItems.Add(norme.getDate().ToString());
                    lvi.SubItems.Add(norme.getNorme());


                    lvEtape.Items.Add(lvi);
                }
                
            }
        }
    }
}
