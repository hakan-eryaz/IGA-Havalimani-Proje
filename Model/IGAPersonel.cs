using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGA_Havalimanı_Yönetim_Proje.Model
{
    class IGAPersonel : Person
    {
        private int IgaID;
        private int DepartmanID;
        private string Password;

        public IGAPersonel(int ıgaID, int departmanID, string password)
        {
            IgaID = ıgaID;
            DepartmanID = departmanID;
            Password = password;
        }

        public int IgaID1 { get => IgaID; set => IgaID = value; }
        public int DepartmanID1 { get => DepartmanID; set => DepartmanID = value; }
        public string Password1 { get => Password; set => Password = value; }
        public IGAPersonel()
        {

        }
        
        public bool Giris(string email, string password, int departmanıd)
        {
            
            string connectionString = "server=DESKTOP-L8J5HEE; Database = Proje; Trusted_Connection = True; ";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {

                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    string query = $"select * from IgaPersonel WHERE Email='{email}' AND Password ='{password}' AND DepartmanID='{departmanıd}'";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {

                throw new Exception("Error in Login");
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
            SqlCommand veriekle = new SqlCommand("insert into IgaPersonel(Ad,Soyad,TelNo,Email,DoğumTarihi,Cinsiyet,DepartmanID,Password) " +
                "values(@Ad,@Soyad,@TelNo,@Email,@DoğumTarihi,@Cinsiyet,@DepartmanID,@Password)", connection);

            veriekle.Parameters.AddWithValue("@Ad", Ad);
            veriekle.Parameters.AddWithValue("@Soyad", Soyad);
            veriekle.Parameters.AddWithValue("@TelNo", TelNo);
            veriekle.Parameters.AddWithValue("@Email", Email);
            veriekle.Parameters.AddWithValue("@DoğumTarihi", DoğumTarihi);
            veriekle.Parameters.AddWithValue("@Cinsiyet", Cinsiyet);
            veriekle.Parameters.AddWithValue("@DepartmanID", DepartmanID1);
            veriekle.Parameters.AddWithValue("@Password", Password1);
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

        public int Düzenle()
        {
            string connectionString = "server=DESKTOP-L8J5HEE; Database = Proje; Trusted_Connection = True; ";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = $"update IgaPersonel  set Ad=@Ad,Soyad=@Soyad,TelNo=@TelNo,Email=@Email," +
                    $"DoğumTarihi=@DoğumTarihi,Cinsiyet=@Cinsiyet,DepartmanID=@DepartmanID,Password=@Password where IgaID =@IgaID";
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
                    command.Parameters.AddWithValue("@DepartmanID", DepartmanID);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@IgaID", IgaID);
                    
                }
               return command.ExecuteNonQuery();
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
            string kayit = "delete From IgaPersonel where IgaID=" + IgaID1 + "";

            SqlCommand command = new SqlCommand(kayit, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.SelectCommand = command;
            DataTable dataTable = new DataTable();
            int result =adapter.Fill(dataTable);
                return adapter.Fill(dataTable);
            
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }


    }
}

