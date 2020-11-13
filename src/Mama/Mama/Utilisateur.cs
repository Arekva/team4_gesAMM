using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mama
{
    class Utilisateur
    {
        private int id;
        private string login;
        private string mdp;

        public Utilisateur(int lId, string leLogin, string leMdp)
        {
            this.id = lId;
            this.login = leLogin;
            this.mdp = leMdp;
        }

        //Get
        public int getId() { return this.id; }
        public string getLogin() { return this.login; }
        public string getMdp() { return this.mdp; }


        //Set

        public void setId(int leId) { this.id = leId; }
        public void setLogin(string leLogin) { this.login = leLogin; }
        public void setMdp(string leMdp) { this.mdp = leMdp; }
    }
}
