using StudentskiDogodki;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiDogodki
{
    public class Prizorisce
    {
        private Tip tip { get; set; }
        
        private enum Tip
        {
            stadion, dvorana, javnaPovrsina
        }
        private Lokacija lokacija;
        private bool naProstem;
        private int maksimalnoStojisce;
        private int maksimalnoSedisce;

        public Lokacija Lokacija
        {
            get { return lokacija; }
            set { lokacija = value; }
        }

        public bool NaProstem
        {
            get { return naProstem; }
            set { naProstem = value; }
        }

        public int MaksimalnoStojisc
        {
            get { return maksimalnoStojisce; }
            set { maksimalnoStojisce = value; }
        }

        public int MaksimalnoSedisc
        {
            get { return maksimalnoSedisce; }
            set { maksimalnoSedisce = value; }
        }

        public Prizorisce() { }

        public Prizorisce(int maksimalnoStojisc) : this(new Lokacija(), false, maksimalnoStojisc, 0) { }

        public Prizorisce(Lokacija lokacija, bool naProstem, int maksimalnoStojisc, int maksimalnoSedisc)
        {
            Lokacija = lokacija;
            NaProstem = naProstem;
            MaksimalnoStojisc = maksimalnoStojisc;
            MaksimalnoSedisc = maksimalnoSedisc;
        }

        public override string ToString()
        {
            return $"Prizorisce: tip: {tip}, na prostem: {naProstem}, maksimalno stevilo stojisc: {MaksimalnoSedisc}, maksimalno stevilo sedezev: {MaksimalnoStojisc}";
        }

    }
}
