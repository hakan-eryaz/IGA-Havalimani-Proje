using IGA_Havalimanı_Yönetim_Proje.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGA_Havalimanı_Yönetim_Proje
{
    public partial class YolcuEkle : Form
    {
        public YolcuEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text)
                     || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox8.Text))
                {
                    MessageBox.Show("Doldurulması zorunlu alanlar boş bırakılamaz !!");
                }
                Yolcular yolcu = new Yolcular();
                
                yolcu.Ad = textBox7.Text.Trim();
                yolcu.Soyad = textBox2.Text.Trim();
                yolcu.TelNo = textBox3.Text.Trim();
                yolcu.Email = textBox4.Text.Trim();
                yolcu.DoğumTarihi = dateTimePicker1.Value;
                yolcu.Cinsiyet = comboBox1.Text.Trim();
                yolcu.KoltukNo1 = textBox8.Text;
                yolcu.BiletStatü1 = textBox5.Text.Trim();
                yolcu.UçuşID1 = Int32.Parse(textBox6.Text.Trim());
                int result = yolcu.Ekle();

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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
