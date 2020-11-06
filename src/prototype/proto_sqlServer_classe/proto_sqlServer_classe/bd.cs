using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace proto_sqlServer_classe
{
    public static class bd
    {
        public static void lireLesClientsAlpha()
        {
            globale.lesClients.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_listeTousClientsAlpha", globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                int idClient = int.Parse(SqlExec["idClient"].ToString());
                string nomClient = SqlExec["nomClient"].ToString();

                client leClient = new client(idClient, nomClient);

                globale.lesClients.Add(leClient);
            }
        }

        public static void lireLesClientsAvecFactures()
        {
            globale.lesClients.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_listeTousClients", globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                int idClient = int.Parse(SqlExec["idClient"].ToString());
                string nomClient = SqlExec["nomClient"].ToString();

                client leClient = new client(idClient, nomClient);

                //gestion des factures du client
                SqlCommand maRequeteFact = new SqlCommand("prc_listeFacturesClient", globale.cnx);
                maRequeteFact.CommandType = System.Data.CommandType.StoredProcedure;
                // Ajouter le paramètre idClient à la procédure stockée
                SqlParameter paramIdClient = new SqlParameter("@idClient", System.Data.SqlDbType.Int, 5);
                paramIdClient.Value = idClient;
                //ajout du paramètre à la procédure stockée
                maRequeteFact.Parameters.Add(paramIdClient);

                // exécuter la procedure stockée dans un curseur 
                SqlDataReader SqlExecFact = maRequeteFact.ExecuteReader();

                //boucle de lecture des clients avec ajout dans la collection
                while (SqlExecFact.Read())
                {
                    int numFact = int.Parse(SqlExecFact["numFact"].ToString()) ;
                    DateTime dateFact = DateTime.Parse(SqlExecFact["dateFact"].ToString());
                    float mtFact = float.Parse(SqlExecFact["mtFact"].ToString());
                    int numClient = idClient;

                    facture laFacture = new facture(numFact, dateFact, mtFact, idClient);
                    leClient.ajouterFacture(laFacture);
                }
                globale.lesClients.Add(leClient);
            }
        }

        public static Boolean ajouterClient(int id, string nom)
        {
            SqlCommand maRequete = new SqlCommand("prc_ajouterClient", globale.cnx);
            // Il s’agit d’une procédure stockée:
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // Ajouter les parameters à la procédure stockée
            SqlParameter paramIdClient = new SqlParameter("@idClient", System.Data.SqlDbType.Int, 5);
            paramIdClient.Value = id;
            SqlParameter paramNomClient = new SqlParameter("@nomClient", System.Data.SqlDbType.Char, 30);
            paramNomClient.Value = nom;
            maRequete.Parameters.Add(paramIdClient);
            maRequete.Parameters.Add(paramNomClient);

            // exécuter la procedure stockée
            try
            {
                maRequete.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
