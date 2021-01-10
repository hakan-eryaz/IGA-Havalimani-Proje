using IGA_Havalimanı_Yönetim_Proje.Model;
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
    public partial class IgaPersonelEkle : Form
    {
        public IgaPersonelEkle()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                if (string.IsNullOrWhiteSpace(textBox1.Text)|| string.IsNullOrWhiteSpace(textBox2.Text)|| string.IsNullOrWhiteSpace(textBox3.Text)
                    || string.IsNullOrWhiteSpace(textBox4.Text)|| string.IsNullOrWhiteSpace(textBox5.Text)|| string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    MessageBox.Show("Doldurulması zorunlu alanlar boş bırakılamaz !!");
                }

                IGAPersonel ıgaPersonel = new IGAPersonel();
                ıgaPersonel.Ad = textBox1.Text;
                ıgaPersonel.Soyad = textBox2.Text;
                ıgaPersonel.TelNo = textBox3.Text;
                ıgaPersonel.Email = textBox4.Text;
                ıgaPersonel.DoğumTarihi = dateTimePicker1.Value;
                ıgaPersonel.Cinsiyet = comboBox1.Text;
                ıgaPersonel.DepartmanID1 = Int32.Parse(textBox5.Text);
                ıgaPersonel.Password1 = textBox6.Text;
                int result = ıgaPersonel.Ekle();
             
                if (result > 0)
                {
                    MessageBox.Show("Başarıyla eklendi");
                }
                else
                {
                    MessageBox.Show("Eklenemedi");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                label10.Text = ex.Message;
                label10.ForeColor = Color.Red;
            }

    }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
                    
        }
    }
}
