using StudentskiDogodki;
using System.Collections.Generic;


namespace StudentskiDogodki
{
    public class Vstopnica
    {
        private int stojisce;
        private Sedez sedez;
        public double cena;
        public DateTime casovniZigProdaje; 

        public int Stojisce
        {
            get { return stojisce; }
            set { stojisce = value; }
        }

        public Sedez Sedez
        {
            get { return sedez; }
            set { sedez = value; }
        }

        public double Cena
        {
            get { return cena; }
            set { cena = value; }
        }

        public DateTime CasovniZigProdaje
        {
            get { return casovniZigProdaje;}
            set { casovniZigProdaje = value; }
        }

        public Vstopnica() { }

        public Vstopnica(int stojisce) : this(stojisce, null, 0, DateTime.MinValue) { }


        public Vstopnica(int stojisce, Sedez sedez, double cena, DateTime casovniZigProdaje)
        {
            Stojisce = stojisce;
            Sedez = sedez;
            Cena = cena;
            CasovniZigProdaje = casovniZigProdaje;
        }

        public override string ToString()
        {
            return $"/n Vstopnica: stojisce {Stojisce},\n cena {Cena},\n cas prodaje {CasovniZigProdaje}";
        }
    }
}
