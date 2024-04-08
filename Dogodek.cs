using StudentskiDogodki;
using System.Collections.Generic;

namespace StudentskiDogodki
{
    internal abstract class Dogodek
    {
        private string naslov;
        private string opis;
        private Prizorisce prizorisce;
        private DateTime datum;
        private TimeSpan cas;
        private bool dobrodelni;
        private int trajanje;
        private double osnovnaCena;
        public enum Kategorija
        {
            glasba, izobrazevanje, sport, prostiCas
        }
        private Kategorija kategorija;
        private List<Vstopnica> prodaneVstopnice;

        public Kategorija KategorijaDogodka
        {
            get { return kategorija; }
            set { kategorija = value; }
        }
        public string Naslov
        {
            get { return naslov; }
            private set { naslov = value; }
        }

        public string Opis
        {
            get { return opis; }
            private set { opis = value; }
        }

        public Prizorisce Prizorisce
        {
            get { return prizorisce; }
            private set { prizorisce = value; }
        }

        public DateTime Datum
        {
            get { return datum; }
            private set { datum = value; }
        }

        public TimeSpan Cas
        {
            get { return cas; }
            private set { cas = value; }
        }

        public bool Dobrodelni
        {
            get { return dobrodelni; }
            private set { dobrodelni = value; }
        }

        public int Trajanje
        {
            get { return trajanje; }
            private set { trajanje = value; }
        }

        public double OsnovnaCena
        {
            get { return osnovnaCena; }
            private set { osnovnaCena = value; }
        }

        public List<Vstopnica> ProdaneVstopnice
        {
            get { return prodaneVstopnice; }
            private set { prodaneVstopnice = value; }
        }

        public Dogodek() { }

        public Dogodek(string naslov) : this(naslov, string.Empty, new Prizorisce(), DateTime.MinValue, TimeSpan.Zero, false, 0, 0) { }


        public Dogodek(string naslov, string opis, Prizorisce prizorisce, DateTime datum, TimeSpan cas, bool dobrodelni, int trajanje, double osnovnaCena)
        {
            Naslov = naslov;
            Opis = opis;
            Prizorisce = prizorisce;
            Datum = datum;
            Dobrodelni = dobrodelni;
            Cas = cas;
            Trajanje = trajanje;
            OsnovnaCena = osnovnaCena;
            ProdaneVstopnice = new List<Vstopnica>();
        }


        public abstract string NagradnaIgra(int steviloVstopnic, List<string> osebe);


        public void DodajVstopnico(Vstopnica vstopnica)
        {
            ProdaneVstopnice.Add(vstopnica);
        }


        public double KoncnaCenaVstopnice(int steviloVstopnic)
        {
            return KoncnaCenaVstopnice(steviloVstopnic, false);
        }

        
        public double KoncnaCenaVstopnice(bool studentPrveStopnje)
        {
            return KoncnaCenaVstopnice(1, studentPrveStopnje);

        }


        public double KoncnaCenaVstopnice(int steviloVstopnic, bool studentPrveStopnje)
        {
            double koncnaCena = OsnovnaCena;

            if (steviloVstopnic >= 5)
            {
                koncnaCena -= OsnovnaCena * 0.10;
            }

            if (studentPrveStopnje)
            {
                koncnaCena -= OsnovnaCena * 0.05;
            }

            return koncnaCena;
        }

        public double KoncnaCenaVstopnice()
        {
            double koncnaCena = OsnovnaCena;

            return koncnaCena;
        }



        public override string ToString()
        {
            return $"\n Dogodek: Naslov {Naslov},\n Opis {Opis},\n prizorisce {Prizorisce},\n datum {Datum},\n cas {Cas},\n dobrodelni {Dobrodelni},\n trajanje {Trajanje},\n osnovna cena {OsnovnaCena},\n Kategorija {KategorijaDogodka}";
        }
    }
}
