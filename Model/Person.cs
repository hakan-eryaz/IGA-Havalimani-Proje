using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGA_Havalimanı_Yönetim_Proje.Model
{
    class Person
    {
        private string ad;
        private string soyad;
        private string telNo;
        private string email;
        private DateTime doğumTarihi;
        private string cinsiyet;

        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string TelNo { get => telNo; set => telNo = value; }
        public string Email { get => email; set => email = value; }
        public DateTime DoğumTarihi { get => doğumTarihi; set => doğumTarihi = value; }
        public string Cinsiyet { get => cinsiyet; set => cinsiyet = value; }
    }
}
