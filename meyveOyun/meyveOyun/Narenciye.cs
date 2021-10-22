
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndp_proje_odev
{
    class Narenciye : Vitamin, IMeyveler
    {
        public int MeyveSik(int gr, int yuzde)
        {
            return (gr * yuzde) / 100;
        }
        public int NetAgirlik()
        {
            Random rnd = new Random();
            return rnd.Next(70, 120);
        }
        public int YuzdeVerim()
        {
            Random rnd = new Random();
            return rnd.Next(30, 70);
        }
        public override int VitaminHesaplaA(int pure_sivi, int oran)
        {
            return (pure_sivi * oran) / 100;
        }
        public override int VitaminHesaplaC(int pure_sivi, int oran)
        {
            return (pure_sivi * oran) / 100;
        }
        public override int OranA(int id)
        {
            if (id == 0)
            {
                return 54;
            }
            else if (id == 1)
            {
                return 25;
            }
            else if (id == 2)
            {
                return 12;
            }
            else if (id == 3)
            {
                return 225;
            }
            else if (id == 4)
            {
                return 681;
            }
            else
            {
                return 3;
            }
        }
        public override int OranC(int id)
        {
            if (id == 0)
            {
                return 5;
            }
            else if (id == 1)
            {
                return 5;
            }
            else if (id == 2)
            {
                return 60;
            }
            else if (id == 3)
            {
                return 45;
            }
            else if (id == 4)
            {
                return 26;
            }
            else
            {
                return 44;
            }
        }
    }
}
