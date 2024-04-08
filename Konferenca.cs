using StudentskiDogodki;
using System.Collections.Generic;
using System.Text;

namespace StudentskiDogodki
{
    internal class Konferenca : Dogodek
    {
        private List<string> seznamPredavanj;
        private bool pogostitevVkljucena; 

        public List<string> SeznamPredavanj
        {
            get { return seznamPredavanj; }
            set { seznamPredavanj = value; }
        }

        public bool PogostitevVkljucena
        {
            get { return pogostitevVkljucena; }
            set { pogostitevVkljucena = value; }
        }

        public Konferenca(string naslov, string opis, Prizorisce prizorisce, DateTime datum, TimeSpan cas, bool dobrodelni, int trajanje, double osnovnaCena,
                          List<string> seznamPredavanj, bool pogostitevVkljucena)
                          : base(naslov, opis, prizorisce, datum, cas, dobrodelni, trajanje, osnovnaCena)
        {
            SeznamPredavanj = seznamPredavanj;
            PogostitevVkljucena = pogostitevVkljucena;
        }

        public override string NagradnaIgra(int steviloVstopnic, List<string> osebe)
        {
            StringBuilder rezultat = new StringBuilder();
            Random rng = new Random();

            for (int i = 0; i < steviloVstopnic && osebe.Count > 0; i++)
            {
                int index = rng.Next(osebe.Count);
                string izbranaOseba = osebe[index];
                osebe.RemoveAt(index);

                Vstopnica novaVstopnica = new Vstopnica() { Cena = this.OsnovnaCena * 0.1, CasovniZigProdaje = DateTime.Now };
                this.ProdaneVstopnice.Add(novaVstopnica);

                rezultat.AppendLine($"{izbranaOseba}: Vstopnica Cena = {novaVstopnica.Cena}, Cas prodaje = {novaVstopnica.CasovniZigProdaje}");
            }

            return rezultat.ToString();
        }


        public sealed override string ToString()
        {
            string predavanja = string.Join(", ", SeznamPredavanj);
            string pogostitev = PogostitevVkljucena ? "Da" : "Ne";
            return base.ToString() + $", Seznam predavanj: {predavanja},\n Pogostitev vkljucena: {pogostitev}";
        }
    }
}
