namespace Mama
{
    public class Medicament
    {
        public string DepotLegal { get; set; } = null;
        public string NomCommercial { get; set; } = null;
        public string Composition { get; set; } = null;
        public string Effets { get; set; } = null;
        public string ContreIndications { get; set; } = null;
        public string AMM { get; set; } = null;
        public int DerniereEtape { get; set; } = 0;
        public Famille Famille { get; set; } = null;
    }
}