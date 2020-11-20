using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mama
{
    /// <summary>
    /// Classe medicament constituer de tous les attributs lié aux médicaments.
    /// </summary>
    /// \Author Gaétan Fontan

    class Medicament
    {
        private string depotLegal; // clé primaire
        private string nomCommercial;
        private string composition;
        private string effets;
        private string contreIndication;
        private string AMM; //code de l'autorisation de la mise en marché est null si le medoc n'est pas autoriser
                            //NULL A SA CREATION
        private List<Etape> toutesLesEtapes; // il s'agit de la liste de toutes les étapes de verification nécessaire
        private Etape DerniereEtape; //il s'agit de la derniere étape de test effectuer 
                                     //NULL A SA CREATION
        private Famille laFamille; // la famille du medicament

        /// <summary>
        /// Peremet l'instanciation de la classe Medicament
        /// </summary>
        /// <param name="leDepot">Il s'agit de la clé primaire, et le code de la classe Médicament.</param>
        /// <param name="leNomCommercial">Il s'agit du nom du médicament tel qu'il sera vendu</param>
        /// <param name="laComposition"> Resume la composition du medicaments</param>
        /// <param name="leEffet"> L'effet théorique du médicament suite a sa prise (par exemple : soulage les douleurs de dos)</param>
        /// <param name="laContreIndication"> Précise dans quelle conditions le médicaments ne doit pas être pris</param>
        /// <param name="laaFamille"> Précise la famille du médicament </param>
        /// \Author Gaétan Fontan
        public Medicament(string leDepot, string leNomCommercial, string laComposition, string leEffet,
            string laContreIndication, Famille laaFamille)
        {
            this.depotLegal = leDepot;
            this.nomCommercial = leNomCommercial;
            this.composition = laComposition;
            this.effets = leEffet;
            this.contreIndication = laContreIndication;
            this.laFamille = laaFamille;
            this.AMM = null;
            this.DerniereEtape = null;
        }

        /// <summary>
        /// Fonction permetant d'obtenir (de retourné) le code du dépot legal du médicament
        /// </summary>
        /// <returns> retourne une chaine de caractere </returns>
        /// \author gaétan fontan \n \n
        /// \emoji :smile: veuillez telecharger le script pour rajouter des smiley
        /// \date 20/11/2022
        /// \bug La fonction ne retourne pas toujours le bon résultat
        /// \code{.cs} //ceci est un commentaire codé en c# \endcode
        /// \details Ceci est l'explication détailler de la fonction getDepotLegal : la fonction est composé des lettres g, e, t, D, e (un deuxieme e), p, o, t, l , e , g , a, l \n \n
        /// \anchor Ceci Ceci est un pied de page

        public string getDepotLegal() { return this.depotLegal; }
        public string getNomCommercial() { return this.nomCommercial; }
        public string getComposition() { return this.composition; }
        public string getContreIndication() { return this.contreIndication; }
        public string getAMM() { return this.AMM; }
        public Etape getDerniereEtape() { return this.DerniereEtape; }
        public Famille getFamille() { return this.laFamille; }

        /// <summary>
        /// Permet d'attribuer le code du dépot légal au médicament
        /// </summary>
        /// <param name="leCode">Correspond au nouveau code voulu, c'est une chaine de caractere</param>
        /// \author Gaétan Fontan
        /// \date 20/11/2022
        public void setDepotLogal(string leCode) { this.depotLegal = leCode; }
        public void setNomCommercial(string leNom) { this.nomCommercial = leNom; }
        public void setComposition(string laCompo) { this.composition= laCompo; }
        public void setContreIndication(string lindication) { this.contreIndication = lindication; }
        public void setAMM(string laAMM) { this.AMM = laAMM; }
        public void setDerniereEtape(Etape lEtape) { this.DerniereEtape = lEtape; }
        public void setFamille(Famille laNewFamille) { this.laFamille = laNewFamille; }



    }
}
