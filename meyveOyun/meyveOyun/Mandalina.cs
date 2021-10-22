
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndp_proje_odev
{
    class Mandalina : Narenciye, IOlustur
    {
        private string _AdMeyve;
        private bool _MeyveKontrol;
        private int _GrAgirlik;
        private int _GrPure;
        private int _Verim;
        private int _VitaminA;
        private int _OranA;
        private int _VitaminC;
        private int _OranC;

        public string AdMeyve
        {
            get
            {
                return _AdMeyve;
            }
        }
        public bool MeyveKontrol
        {
            get
            {
                return _MeyveKontrol;
            }
        }
        public int GrAgirlik
        {
            get
            {
                return _GrAgirlik;
            }
        }
        public int GrPure
        {
            get
            {
                return _GrPure;
            }
        }
        public int Verim
        {
            get
            {
                return _Verim;
            }
        }
        public int VitaminA
        {
            get
            {
                return _VitaminA;
            }
        }
        public int VitaminC
        {
            get
            {
                return _VitaminC;
            }
        }

        public void MeyveYap(int id)
        {
            _MeyveKontrol = KatiMi(id);
            _OranA = OranA(id);
            _OranC = OranA(id);
            _AdMeyve = "Mandalina";
            _GrAgirlik = NetAgirlik();
            _Verim = YuzdeVerim();
            _GrPure = MeyveSik(_GrAgirlik, _Verim);
            _VitaminA = VitaminHesaplaA(_GrPure, OranA(id));
            _VitaminC = VitaminHesaplaC(_GrPure, OranC(id));
        }

        public bool KatiMi(int index)
        {
            if (index < 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
