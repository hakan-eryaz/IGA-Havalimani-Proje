using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGA_Havalimanı_Yönetim_Proje.Model
{
    class Uçuş
    {
        private int UçuşID;
        private int UçakID;
        private string KalkışTarih;
        private string KalkışSaat;
        private string İnişTarih;
        private string İnişSaat;
        private string KalkışKonum;
        private string İnişKonum;

        public int UçuşID1 { get => UçuşID; set => UçuşID = value; }
        public int UçakID1 { get => UçakID; set => UçakID = value; }
        public string KalkışTarih1 { get => KalkışTarih; set => KalkışTarih = value; }
        public string KalkışSaat1 { get => KalkışSaat; set => KalkışSaat = value; }
        public string İnişTarih1 { get => İnişTarih; set => İnişTarih = value; }
        public string İnişSaat1 { get => İnişSaat; set => İnişSaat = value; }
        public string KalkışKonum1 { get => KalkışKonum; set => KalkışKonum = value; }
        public string İnişKonum1 { get => İnişKonum; set => İnişKonum = value; }

        public int Ekle()
        {
            SqlConnection connection = new SqlConnection("server=DESKTOP-L8J5HEE; Database = Proje; Trusted_Connection = True; ");
            try
            {

                connection.Open();
                SqlCommand veriekle = new SqlCommand("insert into Uçuşlar(UçakID,KalkışTarih,KalkışSaat,İnişTarih,İnişSaat,KalkışKonum,İnişKonum) " +
                    "values(@UçakID,@KalkışTarih,@KalkışSaat,@İnişTarih,@İnişSaat,@KalkışKonum,@İnişKonum)", connection);

                
                veriekle.Parameters.AddWithValue("@UçakID", UçakID);
                veriekle.Parameters.AddWithValue("@KalkışTarih", KalkışTarih);
                veriekle.Parameters.AddWithValue("@KalkışSaat", KalkışSaat);
                veriekle.Parameters.AddWithValue("@İnişTarih", İnişTarih);
                veriekle.Parameters.AddWithValue("@İnişSaat", İnişSaat);
                veriekle.Parameters.AddWithValue("@KalkışKonum", KalkışKonum);
                veriekle.Parameters.AddWithValue("@İnişKonum", İnişKonum);
               

                return veriekle.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();

            }

        }
        public int Sil()
        {

            SqlConnection connection = new SqlConnection("server=DESKTOP-L8J5HEE; Database = Proje; Trusted_Connection = True; ");

            try
            {

                connection.Open();
                string kayit = "delete From Uçuşlar where UçuşID=" + UçuşID1 + "";

                SqlCommand command = new SqlCommand(kayit, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.SelectCommand = command;
                DataTable dataTable = new DataTable();
                int result = adapter.Fill(dataTable);
                return adapter.Fill(dataTable);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public int Düzenle()
        {
            string connectionString = "server=DESKTOP-L8J5HEE; Database = Proje; Trusted_Connection = True; ";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = $"update Uçuşlar  set UçakID=@UçakID,KalkışTarih=@KalkışTarih,KalkışSaat=@KalkışSaat" +
                $",İnişTarih=@İnişTarih,İnişSaat=@İnişSaat,KalkışKonum=@KalkışKonum,İnişKonum=@İnişKonum where UçuşID =@UçuşID";
            SqlCommand veriekle = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {

                    veriekle.Parameters.AddWithValue("@UçuşID", UçuşID1);
                    veriekle.Parameters.AddWithValue("@UçakID", UçakID);
                    veriekle.Parameters.AddWithValue("@KalkışTarih", KalkışTarih);
                    veriekle.Parameters.AddWithValue("@KalkışSaat", KalkışSaat);
                    veriekle.Parameters.AddWithValue("@İnişTarih", İnişTarih);
                    veriekle.Parameters.AddWithValue("@İnişSaat", İnişSaat);
                    veriekle.Parameters.AddWithValue("@KalkışKonum", KalkışKonum);
                    veriekle.Parameters.AddWithValue("@İnişKonum", İnişKonum);

                }
                return veriekle.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Error in Update");
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
