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
    public partial class IgaYönetim : Form
    {
        public IgaYönetim()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int Move;
        int Mouse_X;
        int Mouse_Y;
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("server=DESKTOP-L8J5HEE; Database = Proje; Trusted_Connection = True; ");

            //connection.Open();
            string kayit = "SELECT * From IgaPersonel";
            string kayit2 = "SELECT * From Departman";
            SqlCommand command = new SqlCommand(kayit, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.SelectCommand = command;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            SqlCommand command2 = new SqlCommand(kayit2, connection);
            SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
            adapter.SelectCommand = command2;
            DataTable dataTable2 = new DataTable();
            adapter.Fill(dataTable2);
            dataGridView2.DataSource = dataTable2;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            IgaDüzenle ıgaDüzenle = new IgaDüzenle();
            this.Hide();
            ıgaDüzenle.ShowDialog();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            IgaPersonelEkle ıgaPersonelEkle = new IgaPersonelEkle();
            this.Hide();
            ıgaPersonelEkle.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IgaPersonelSil ıgaPersonelSil = new IgaPersonelSil();
            this.Hide();
            ıgaPersonelSil.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IgaPersonelAra ıgaPersonelAra = new IgaPersonelAra();
            this.Hide();
            ıgaPersonelAra.ShowDialog();
            this.Show();
        }
    }
}
