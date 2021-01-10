using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGA_Havalimanı_Yönetim_Proje.Model
{
    class KabinEkibi:Person
    {
        private int KabinID;
        private int UçuşID;
        private int HavayoluID;
        

        public KabinEkibi(int kabinID, int uçuşID, int havayoluID)
        {
            KabinID = kabinID;
            UçuşID = uçuşID;
            HavayoluID = havayoluID;
          
        }

        public int KabinID1 { get => KabinID; set => KabinID = value; }
        public int UçuşID1 { get => UçuşID; set => UçuşID = value; }
        public int HavayoluID1 { get => HavayoluID; set => HavayoluID = value; }
    }
}
