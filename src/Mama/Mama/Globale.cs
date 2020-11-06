using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Mama
{
    public static class Globale
    {
        /// <summary>
        /// Toutes les familles de médicament.
        /// </summary>
        public static Dictionary<string, Famille> Familles { get; } = new Dictionary<string, Famille>()
        {
            // familles test le temps d'avoir la base, après il faudra les charger dans static Globale()
            
            { "AA" , new Famille("AA", "Antalgiques en association", 20) },
            { "AIM", new Famille("B", "Antidépresseur imipraminique (tricyclique)", 15) },
            { "PSA", new Famille("PSA","Psychostimulant, antiasthénique", 50) }
        };

        // le constructeur statique s'éxécute dès que quelque chose accède à cette classe.
        static Globale()
        {
            //todo: à faire quand la base sera fini.
            
            /*Famille[] familles = Famille.ToutesLesFamilles().ToArray();
            Familles = new Dictionary<string, Famille>(familles.Length);
            
            for (int i = 0; i < familles.Length; i++)
            {
                familles.Add(familles[i].Code, familles[i]);
            }*/
        }
    }
}
