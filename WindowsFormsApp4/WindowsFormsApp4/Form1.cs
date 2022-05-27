using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //KÜÇÜK TİP BÜYÜK
            byte b1 = 125;
            int d = b1;
            MessageBox.Show(d.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //KÜÇÜK TİP BÜYÜK TİP BİLİÇLİ DEĞİŞİMİ
            double d = 12.5;
            int i = (int)d;
            MessageBox.Show("değişkenin ilk değeri " + d + " değişkenin son değeri "+ i );
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string s = "123456";
            int s2 = Convert.ToInt16(s);
            MessageBox.Show(s2.ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //TO STRİNG
            DateTime date = Convert.ToDateTime("11/05/2022");
            MessageBox.Show(date.ToString()+ "\n" + date.ToLongDateString()  );
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string h = "256";
            string h2 = "125";
            bool rakam = byte.TryParse(h, out byte sonuc);
        }
    }
}
