using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndp_proje_odev
{
    abstract class Vitamin
    {
        public abstract int VitaminHesaplaA(int pure_sivi, int oran);
        public abstract int OranA(int id);
        public abstract int VitaminHesaplaC(int pure_sivi, int oran);
        public abstract int OranC(int id);
    }
}
