using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{

    public class Ekmek
    {
        public int Adet { get; set; }
        public string Tur { get; set; }
        public Ekmek() : this(1, "Buğday") { }
        public Ekmek(int adet) : this(adet, "Buğday") { }

        public Ekmek(string tur) : this(1, tur) { }
        public Ekmek(int adet = 1, string tur = "Buğday") : base()
        {
            Adet = adet;
            Tur = tur;
        }

    }
}
