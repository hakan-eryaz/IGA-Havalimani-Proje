using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGA_Havalimanı_Yönetim_Proje
{
    public partial class YerHizAra : Form
    {
        public YerHizAra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection("server=DESKTOP-L8J5HEE; Database = Proje; Trusted_Connection = True; ");
                string text = textBox5.Text;
                connection.Open();
                string kayit = "SELECT * From YerHizmetleriPersonel where YerHizID=" + text + "";

                SqlCommand command = new SqlCommand(kayit, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.SelectCommand = command;
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                int sayi = int.Parse(textBox5.Text);
            ProjeEntities projeEntities = new ProjeEntities();
            var query = from g in projeEntities.Havayolları
                        join m in projeEntities.YerHizmetleriPersonel on g.HavayoluID equals m.HavayoluID
                        where m.YerHizID == sayi
                        select new
                        {
                            HavayoluID=m.HavayoluID,
                            Ad = g.Ad,
                            Ülke = g.Ülke,
                            TelNo = g.TelNo,
                            Email = g.Email
                        };
            dataGridView2.DataSource = query.ToList();

                connection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
