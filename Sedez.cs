using StudentskiDogodki;
using System.Collections.Generic;


namespace StudentskiDogodki
{
    public class Sedez
    {
        private int vrsta;
        private int stevilkaSedeza;

        public int Vrsta
        {
            get { return vrsta; }
            set { vrsta = value; }
        }

        public int StevilkaSedeza
        {
            get { return stevilkaSedeza; }
            set { stevilkaSedeza = value; }
        }


        public Sedez() { }

        public Sedez(int vrsta)
        {
            Vrsta = vrsta;
        }

        public Sedez(int vrsta, int sedez): this(vrsta)
        {
            StevilkaSedeza = sedez;
        }
        public override string ToString()
        {
            return $"\n Sedez: vrsta {Vrsta},\n stevilka sedeza {StevilkaSedeza}";
        }
    }
}
