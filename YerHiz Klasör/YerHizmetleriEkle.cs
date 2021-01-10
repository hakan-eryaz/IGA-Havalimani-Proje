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
    public partial class YerHizmetleriEkle : Form
    {
        public YerHizmetleriEkle()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text)
                     || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text)|| string.IsNullOrWhiteSpace(textBox8.Text))
                {
                    MessageBox.Show("Doldurulması zorunlu alanlar boş bırakılamaz !!");
                }
                YerHizmetleriPersoneller yerPersonel = new YerHizmetleriPersoneller();
                yerPersonel.Ad = textBox1.Text;
                yerPersonel.Soyad = textBox2.Text;
                yerPersonel.TelNo=textBox3.Text;
                yerPersonel.Email = textBox4.Text;
                yerPersonel.DoğumTarihi = dateTimePicker1.Value;
                yerPersonel.Cinsiyet = comboBox1.Text;
                yerPersonel.HavayoluID1 = Int32.Parse(textBox8.Text.Trim());
                yerPersonel.DepartmanID1 = Int32.Parse(textBox5.Text);
                yerPersonel.Password1 = textBox6.Text;
                int result = yerPersonel.Ekle();

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
                label11.Text = ex.Message;
                label11.ForeColor = Color.Red;
            }

        }
    }
}
