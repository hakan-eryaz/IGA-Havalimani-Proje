using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGA_Havalimanı_Yönetim_Proje.Model
{
    class Havayolu
    {
        private int HavayoluID;
        private string Ad;
        private string Ülke;
        private string TelNo;
        private string Email;

        public Havayolu(int havayoluID, string ad, string ülke, string telNo, string email)
        {
            HavayoluID = havayoluID;
            Ad = ad;
            Ülke = ülke;
            TelNo = telNo;
            Email = email;
        }
        public Havayolu()
        {

        }
        
    }
}
