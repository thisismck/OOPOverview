using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Yemek
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        public int PismeSuresi { get; set; }
        public List<string> Malzemeler { get; set; }

        public void Pisir()
        {
            Console.WriteLine($"{GetType().Name}, {PismeSuresi} dakikada pisirildi");
        }

        public virtual void SunumYap()
        {
            Console.WriteLine($"{GetType().Name} pilavla sunum yapildi");
        }
    }

    public class Corba : Yemek
    {
        public bool LimonEklenebilirMi { get; set; }
    }

    public class EtYemek : Yemek
    {
        public string EtTuru { get; set; }
    }

    public class Kofte : EtYemek
    {
        public bool BaharatliMi { get; set; }
    }

    public class Tatli : Yemek
    {
        public bool SutluMu { get; set; }
        public override void SunumYap()
        {
            Console.WriteLine($"{GetType().Name} üzerine ceviz serpildi");
        }
    }

    public class Kazandibi : Tatli
    {
        public bool KaramelizeMi { get; set; }
    }
    public class Pilav : Yemek
    {
        public bool NohutluMu { get; set; }
    }
}
