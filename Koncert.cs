using StudentskiDogodki;
using System.Collections.Generic;
using System.Text;

namespace StudentskiDogodki
{
    internal class Koncert : Dogodek
    {
        private List<string> seznamNastopajocih;

        public List<string> SeznamNastopajocih
        {
            get { return seznamNastopajocih; }
            set { seznamNastopajocih = value; }
        }

        public Koncert(string naslov, string opis, Prizorisce prizorisce, DateTime datum, TimeSpan cas, bool dobrodelni, int trajanje, double osnovnaCena,
                       List<string> seznamNastopajocih)
                       : base(naslov, opis, prizorisce, datum, cas, dobrodelni, trajanje, osnovnaCena)
        {
            SeznamNastopajocih = seznamNastopajocih;
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

                Vstopnica novaVstopnica = new Vstopnica() { Cena = 0, CasovniZigProdaje = DateTime.Now };
                this.ProdaneVstopnice.Add(novaVstopnica);

                rezultat.AppendLine($"{izbranaOseba}: Vstopnica Cena = {novaVstopnica.Cena}, Cas prodaje = {novaVstopnica.CasovniZigProdaje}");
            }

            return rezultat.ToString();
        }



        public sealed override string ToString()
        {
            string nastopajoci = string.Join(", ", SeznamNastopajocih);
            return base.ToString() + $", Seznam nastopajocih: {nastopajoci}";
        }
    }
}
