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
    public partial class UçuşAra : Form
    {
        public UçuşAra()
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
                string kayit = "SELECT * From Uçuşlar where UçuşID=" + text + "";

                SqlCommand command = new SqlCommand(kayit, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.SelectCommand = command;
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
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
