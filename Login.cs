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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            IGAPersonel ıGAPersonel = new IGAPersonel(); 
            YerHizmetleriPersoneller yerHizmetleri = new YerHizmetleriPersoneller();
            try
            {
                labelMessage.Text = "";
                labelMessage.ForeColor = Color.Black;
                string email1 = textBox1.Text.Trim();
                string password1 = textBox2.Text.Trim();
                int departmanıd1 = Int32.Parse(textBox3.Text);

                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    labelMessage.Text = "Lütfen email girin";
                    labelMessage.ForeColor = Color.Red;
                    textBox1.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    labelMessage.Text = "Lütfen şifre girin";
                    labelMessage.ForeColor = Color.Red;
                    textBox2.Focus();
                    return;
                }
                if (departmanıd1 == 0 || departmanıd1 < 0)
                {
                    labelMessage.Text = "Lütfen DepartmanID girin";
                    labelMessage.ForeColor = Color.Red;
                    textBox3.Focus();
                    return;
                }
                
                var result = ıGAPersonel.Giris(email1,password1,departmanıd1);
               
                var sonuc = yerHizmetleri.Giris(email1, password1, departmanıd1);
                if (result == true||sonuc==true)
                {
                    AnaSayfa anaSayfa = new AnaSayfa();
                    this.Hide();
                    anaSayfa.ShowDialog();
                    this.Show();
                }
                else
                {
                    labelMessage.Text="Kullanıcı adı şifre veya departman ıd hatalı";
                    labelMessage.ForeColor = Color.Red;
                }

            }

            catch (Exception)
            {
                labelMessage.Text = "Girişte hata oluştu";
                labelMessage.ForeColor = Color.Red;
            }



        }

            private void button3_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        } 
} 
    
