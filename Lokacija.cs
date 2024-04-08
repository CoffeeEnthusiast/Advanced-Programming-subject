using StudentskiDogodki;
using System.Collections.Generic;

namespace StudentskiDogodki
{
    public class Lokacija
    {
        private string ulica;
        public string hisnaStevilka;
        public int postnaStevilka;
        public string kraj;

        public string Ulica
        {
            get { return ulica; }
            set { ulica = value; }
        }

        public string HisnaStevilka
        {
            get { return hisnaStevilka; }
            set {  hisnaStevilka = value; }
        }

        public int PostnaStevilka
        {
            get { return postnaStevilka; }
            set {  postnaStevilka = value; }
        }

        public string Kraj
        {
            get { return kraj; }
            set { kraj = value; }
        }

        public Lokacija() { }

        public Lokacija(string ulica) : this(ulica, string.Empty, 0, string.Empty) { }

        public Lokacija(string ulica, string hisnaStevilka, int postnaStevilka, string kraj)
        {
            Ulica = ulica;
            HisnaStevilka = hisnaStevilka;
            PostnaStevilka = postnaStevilka;
            Kraj = kraj;
        }

        public override string ToString()
        {
            return $"\n Lokacija: Ulica: {Ulica},\n hisna stevilka: {HisnaStevilka},\n postna stevilka {PostnaStevilka},\n kraj: {Kraj}";
        }
    }
}
