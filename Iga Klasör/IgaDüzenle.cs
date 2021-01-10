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
    public partial class IgaDüzenle : Form
    {
        public IgaDüzenle()
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
                IGAPersonel ıGAPersonel = new IGAPersonel();
            ıGAPersonel.Ad = textBox7.Text.Trim();
            ıGAPersonel.Soyad = textBox2.Text.Trim();
            ıGAPersonel.TelNo = textBox3.Text.Trim();
            ıGAPersonel.Email = textBox4.Text.Trim();
            ıGAPersonel.DoğumTarihi = dateTimePicker1.Value;
            ıGAPersonel.Cinsiyet = comboBox1.Text.Trim();
            ıGAPersonel.DepartmanID1 =Int32.Parse(textBox5.Text.Trim());
            ıGAPersonel.Password1 = textBox6.Text.Trim();
            ıGAPersonel.IgaID1 = Int32.Parse(textBox1.Text.Trim());
                
            int result = ıGAPersonel.Düzenle();

            if (result == 1)
            {
                IgaYönetim ıgaYönetim = new IgaYönetim();
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
