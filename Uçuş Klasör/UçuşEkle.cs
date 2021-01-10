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
    public partial class UçuşEkle : Form
    {
        public UçuşEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                if (string.IsNullOrWhiteSpace(textBox2.Text)|| string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text)
                    || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text)|| string.IsNullOrWhiteSpace(textBox7.Text) || string.IsNullOrWhiteSpace(textBox8.Text))
                {
                    MessageBox.Show("Doldurulması zorunlu alanlar boş bırakılamaz !!");
                }
                
                Uçuş uçuşlar = new Uçuş();
               
                uçuşlar.UçakID1 = int.Parse(textBox2.Text);
                uçuşlar.KalkışTarih1 = textBox5.Text;
                uçuşlar.KalkışSaat1 = textBox4.Text;
                uçuşlar.İnişTarih1 = textBox8.Text;
                uçuşlar.İnişSaat1 = textBox3.Text;
                uçuşlar.KalkışKonum1 = textBox6.Text;
                uçuşlar.İnişKonum1 = textBox7.Text;
                int result = uçuşlar.Ekle();

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
