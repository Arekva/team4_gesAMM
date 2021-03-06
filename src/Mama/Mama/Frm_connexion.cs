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
    public partial class Frm_connexion : Form
    {
        public static Frm_connexion Instance { get; private set; }
        public Frm_connexion()
        {
            Instance = this;
            InitializeComponent();
        }

        public void showConnection()
        {
            this.Show();
        }

        private void Frm_connexion_Load(object sender, EventArgs e)
        {
            int WScreen = Screen.PrimaryScreen.Bounds.Width;
            int HScreen = Screen.PrimaryScreen.Bounds.Height;
            tbLogin.Location = new Point(WScreen/2 - (tbLogin.Size.Width / 2), 400);
            lbLogin.Location = new Point(WScreen/2- (lbLogin.Size.Width / 2), 350);
            tbPassword.Location = new Point(WScreen/2- (tbPassword.Size.Width / 2), 500);
            lbPassword.Location = new Point(WScreen/2- (lbPassword.Size.Width / 2), 450);
            btConnect.Location = new Point(WScreen/2- (btConnect.Size.Width / 2), 550);
            lbLogin.BringToFront();
            pbLogo.Width = tbLogin.Width;
            pbLogo.Location = new Point(WScreen/2- (pbLogo.Size.Width / 2), 250 - pbLogo.Height /2);
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            bool trouve = false;
            int i = 0;
            while (!trouve && i < Globale.Utilisateurs.Count())
            {
                if(Globale.Utilisateurs.ElementAt(i).Value.getLogin() == tbLogin.Text && Globale.Utilisateurs.ElementAt(i).Value.getMdp() == tbPassword.Text)
                {
                    trouve = true;
                    Main_Form laForm = new Main_Form(Globale.Utilisateurs.ElementAt(i).Value.getId()); //On instancie la form avec pour param l'id de l'utilisateur avec lequel on s'est connécté
                    this.Hide();//On cache pour réafficher la form en cas de deconnection
                    laForm.ShowDialog();
                }
                i++;
            }
            if (!trouve)
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect !");
                
            }/*
            Main_Form laForm = new Main_Form();
            this.Hide();//On cache pour réafficher la form en cas de deconnection
            laForm.ShowDialog();*/


        }
    }
}
