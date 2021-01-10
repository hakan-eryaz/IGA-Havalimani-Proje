using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGA_Havalimanı_Yönetim_Proje.Model
{
    class Yolcular : Person
    {
        private int YolcuID;
        private string KoltukNo;
        private string BiletStatü;
        private int UçuşID;

        public int YolcuID1 { get => YolcuID; set => YolcuID = value; }
        public string KoltukNo1 { get => KoltukNo; set => KoltukNo = value; }
        public string BiletStatü1 { get => BiletStatü; set => BiletStatü = value; }
        public int UçuşID1 { get => UçuşID; set => UçuşID = value; }

        public int Düzenle()
        {
            string connectionString = "server=DESKTOP-L8J5HEE; Database = Proje; Trusted_Connection = True; ";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = $"update Yolcu  set Ad=@Ad,Soyad=@Soyad,TelNo=@TelNo,Email=@Email," +
                        $"DoğumTarihi=@DoğumTarihi,Cinsiyet=@Cinsiyet,KoltukNo=@KoltukNo,BiletStatü=@BiletStatü,UçuşID=@UçuşID where YolcuID =@YolcuID";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {

                    command.Parameters.AddWithValue("@Ad", Ad);
                    command.Parameters.AddWithValue("@Soyad", Soyad);
                    command.Parameters.AddWithValue("@TelNo", TelNo);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@DoğumTarihi", DoğumTarihi);
                    command.Parameters.AddWithValue("@Cinsiyet", Cinsiyet);
                    command.Parameters.AddWithValue("@KoltukNo", KoltukNo);
                    command.Parameters.AddWithValue("@BiletStatü", BiletStatü);
                    command.Parameters.AddWithValue("@UçuşID", UçuşID);
                    command.Parameters.AddWithValue("@YolcuID", YolcuID);

                }
                return command.ExecuteNonQuery();
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
        public int Ekle()
        {
            SqlConnection connection = new SqlConnection("server=DESKTOP-L8J5HEE; Database = Proje; Trusted_Connection = True; ");
            try
            {

                connection.Open();
                SqlCommand veriekle = new SqlCommand("insert into Yolcu(Ad,Soyad,TelNo,Email,DoğumTarihi,Cinsiyet,KoltukNo,BiletStatü,UçuşID) " +
                    "values(@Ad,@Soyad,@TelNo,@Email,@DoğumTarihi,@Cinsiyet,@KoltukNo,@BiletStatü,@UçuşID)", connection);

                veriekle.Parameters.AddWithValue("@Ad", Ad);
                veriekle.Parameters.AddWithValue("@Soyad", Soyad);
                veriekle.Parameters.AddWithValue("@TelNo", TelNo);
                veriekle.Parameters.AddWithValue("@Email", Email);
                veriekle.Parameters.AddWithValue("@DoğumTarihi", DoğumTarihi);
                veriekle.Parameters.AddWithValue("@Cinsiyet", Cinsiyet);
                veriekle.Parameters.AddWithValue("@KoltukNo", KoltukNo);
                veriekle.Parameters.AddWithValue("@BiletStatü", BiletStatü);
                veriekle.Parameters.AddWithValue("@UçuşID", UçuşID);
                
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
                string kayit = "delete From Yolcu where YolcuID=" + YolcuID1 + "";

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
    }
}
