using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGA_Havalimanı_Yönetim_Proje.Model
{
    class Departman
    {
        private int DepartmanID;
        private string Ad;

        public Departman(int departmanID, string ad)
        {
            DepartmanID = departmanID;
            Ad = ad;
        }

        public Departman()
        {
        }

    }
}
