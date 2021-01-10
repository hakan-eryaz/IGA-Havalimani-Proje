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
    public partial class IgaPersonelSil : Form
    {
        public IgaPersonelSil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Id boş olamaz");
            }
                IGAPersonel ıGAPersonel = new IGAPersonel();
                ıGAPersonel.IgaID1 = Int32.Parse(textBox1.Text);
            
            int result=ıGAPersonel.Sil();
                if (result==0)
                {
                    MessageBox.Show("Are you sure to delete?");
                    MessageBox.Show("Başarıyla silindi");
                }
                else if(result>0)
                {
                    MessageBox.Show("Silme Başarısız");
                }
                
            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;
                label2.ForeColor = Color.Red;
            }
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
