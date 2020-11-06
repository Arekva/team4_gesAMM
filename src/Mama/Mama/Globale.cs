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
        public static Dictionary<string, Famille> Familles { get; } = new Dictionary<string, Famille>()
        {
            // familles test le temps d'avoir la base, après il faudra les charger dans static Globale()
            
            { "AA" , new Famille("AA", "Antalgiques en association", 20)},
            { "AIM", new Famille("B", "Antidépresseur imipraminique (tricyclique)", 15)}
        };

        static Globale()
        {
            
        }
    }
}
