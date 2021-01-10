using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGA_Havalimanı_Yönetim_Proje.Model
{
    class Uçaklar
    {
        private int UçakID;
        private int HavayoluID;
        private string ModelNo;
        private string Üretici;

        public Uçaklar(int uçakID, int havayoluID, string modelNo, string üretici)
        {
            UçakID = uçakID;
            HavayoluID = havayoluID;
            ModelNo = modelNo;
            Üretici = üretici;
        }
    }
}
