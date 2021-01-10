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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IgaYönetim ıga = new IgaYönetim();
            this.Hide();
            ıga.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YerHizmetleriYönetim yönetim = new YerHizmetleriYönetim();
            this.Hide();
            yönetim.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YolcuYönetim yolcuYönetim = new YolcuYönetim();
            this.Hide();
            yolcuYönetim.ShowDialog();
            this.Show();
        }
        int Move;
        int Mouse_X;
        int Mouse_Y;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UçuşYönetim uçuşyönetim = new UçuşYönetim();
            this.Hide();
            uçuşyönetim.ShowDialog();
            this.Show();
        }
    }
}
