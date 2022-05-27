using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1;
            int sayi2;
            string s1 = _sayi1.Text;
            string s2 = _sayi2.Text;
            bool ts1 = int.TryParse(s1, out int result);
            bool ts2 = int.TryParse(s2, out int result1);
            if (ts1=true && ts2==true)
            {
                sayi1 = Convert.ToInt32(s1);
                sayi2 = Convert.ToInt32(s2);
                MessageBox.Show("TOPLAMI :" + Convert.ToString(sayi1 + sayi2),"TOPLAM",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("LÜTFEN SAYİSAL BİR DEĞER GİRİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1;
            int sayi2;
            string s1 = _sayi1.Text;
            string s2 = _sayi2.Text;
            bool ts1 = int.TryParse(s1, out int result);
            bool ts2 = int.TryParse(s2, out int result1);
            if (ts1 = true && ts2 == true)
            {
                sayi1 = Convert.ToInt32(s1);
                sayi2 = Convert.ToInt32(s2);
                MessageBox.Show("ÇİKART :" + Convert.ToString(sayi1 - sayi2), "ÇİKAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("LÜTFEN SAYİSAL BİR DEĞER GİRİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1;
            int sayi2;
            string s1 = _sayi1.Text;
            string s2 = _sayi2.Text;
            bool ts1 = int.TryParse(s1, out int result);
            bool ts2 = int.TryParse(s2, out int result1);
            if (ts1 = true && ts2 == true)
            {
                sayi1 = Convert.ToInt32(s1);
                sayi2 = Convert.ToInt32(s2);
                MessageBox.Show("ÇARP:" + Convert.ToString(sayi1 * sayi2), "ÇARPIM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("LÜTFEN SAYİSAL BİR DEĞER GİRİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi1;
            double sayi2;
            string s1 = _sayi1.Text;
            string s2 = _sayi2.Text;
            bool ts1 = double.TryParse(s1, out double result);
            bool ts2 = double.TryParse(s2, out double result1);
            if (ts1 = true && ts2 == true)
            {
                sayi1 = Convert.ToDouble(s1);
                sayi2 = Convert.ToDouble(s2);
                if (sayi2 == 0)
                {
                    MessageBox.Show("HİÇBİR SAYİ 0 BÖLÜNEMEZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("BÖLÜM :" + Convert.ToString(sayi1 / sayi2), "BÖLÜM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show("LÜTFEN SAYİSAL BİR DEĞER GİRİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
