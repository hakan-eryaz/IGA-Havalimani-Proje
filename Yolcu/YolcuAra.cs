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
    public partial class YolcuAra : Form
    {
        public YolcuAra()
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
                string kayit = "SELECT * From Yolcu where YolcuID=" + text + "";

                SqlCommand command = new SqlCommand(kayit, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.SelectCommand = command;
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                int sayi = int.Parse(textBox5.Text);
                ProjeEntities projeEntities = new ProjeEntities();
                var query = from g in projeEntities.Uçuşlar
                            join m in projeEntities.Yolcu on g.UçuşID equals m.UçuşID
                            where m.YolcuID == sayi
                            select new
                            {
                                UçuşID = m.UçuşID,
                                UçakID=g.UçakID,
                                KalkışKonum=g.KalkışKonum,
                                İnişKonum=g.İnişKonum,
                                KalkışTarih = g.KalkışTarih,
                                KalkışSaat = g.KalkışSaat,
                                İnişTarih = g.İnişTarih,
                                İnişSaat=g.İnişSaat
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
    }
}
