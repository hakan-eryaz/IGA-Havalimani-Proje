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
    public partial class YerHizDüzenle : Form
    {
        public YerHizDüzenle()
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
                YerHizmetleriPersoneller yerPersonel = new YerHizmetleriPersoneller();
                yerPersonel.Ad = textBox7.Text.Trim();
                yerPersonel.Soyad = textBox2.Text.Trim();
                yerPersonel.TelNo = textBox3.Text.Trim();
                yerPersonel.Email = textBox4.Text.Trim();
                yerPersonel.DoğumTarihi = dateTimePicker1.Value;
                yerPersonel.Cinsiyet = comboBox1.Text.Trim();
                yerPersonel.HavayoluID1 = Int32.Parse(textBox8.Text.Trim());
                yerPersonel.DepartmanID1 = Int32.Parse(textBox5.Text.Trim());
                yerPersonel.Password1 = textBox6.Text.Trim();
                yerPersonel.YerHizID1 = Int32.Parse(textBox1.Text.Trim());

                int result = yerPersonel.Düzenle();

                if (result == 1)
                {
                    YerHizmetleriYönetim ıgaYönetim = new YerHizmetleriYönetim();
                    MessageBox.Show("Başarı ile güncellendi");
                    this.Hide();
                    ıgaYönetim.ShowDialog();
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
