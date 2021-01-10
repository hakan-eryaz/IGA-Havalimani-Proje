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
    public partial class YolcuDüzenle : Form
    {
        public YolcuDüzenle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    MessageBox.Show("Departman ID boş olamaz");
                }
                Yolcular yolcu = new Yolcular();
                yolcu.YolcuID1 = Int32.Parse( textBox1.Text.Trim());
                yolcu.Ad = textBox7.Text.Trim();
                yolcu.Soyad = textBox2.Text.Trim();
                yolcu.TelNo = textBox3.Text.Trim();
                yolcu.Email = textBox4.Text.Trim();
                yolcu.DoğumTarihi = dateTimePicker1.Value;
                yolcu.Cinsiyet = comboBox1.Text.Trim();
                yolcu.KoltukNo1 = textBox8.Text;
                yolcu.BiletStatü1 = textBox5.Text.Trim();
                yolcu.UçuşID1 = Int32.Parse(textBox6.Text.Trim());
                
                
                

                int result = yolcu.Düzenle();

                if (result == 1)
                {
                    YolcuYönetim yolcuYönetim = new YolcuYönetim();
                    MessageBox.Show("Başarı ile güncellendi");
                    this.Hide();
                    yolcuYönetim.ShowDialog();
                    this.Show();

                }
                else
                {
                    MessageBox.Show("Başarısız güncelleme");
                }

            }
            catch (Exception ex)
            {
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
