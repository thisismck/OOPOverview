using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterface
{
    public class Oyuncu
    {
        public interface IGiyilebilir
        {
            void Giy();
        }
        public abstract class UstGiyim : IGiyilebilir
        {
            public virtual void Giy()
            {
            }
        }
        public class Kazak : UstGiyim
        {
        }
        public class KirmiziKazak : Kazak
        {
        }
        public void Giy(IGiyilebilir kirmiziKazak)
        {
            kirmiziKazak.Giy();
            Console.WriteLine("Oyuncu giydirildi");
        }

    }
}
