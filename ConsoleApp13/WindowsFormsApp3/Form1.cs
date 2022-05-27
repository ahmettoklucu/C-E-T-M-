using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _yassiniri.Text = "18";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dogumTarihi = _dTarihi.Value;
            string adSoyad = _isimsoyisim.Text;

            TimeSpan kacGunGecti = DateTime.Now.Subtract(dogumTarihi);
            DateTime yas = DateTime.MinValue + kacGunGecti;
            int yil = yas.Year - 1;
            int ay = yas.Month - 1;
            int gun = yas.Day - 1;

            string yyil = Convert.ToString(yil);
            string yay = Convert.ToString(ay);
            string ygun = Convert.ToString(gun);
            int myil = Convert.ToInt32(_yassiniri.Text);
            string yas1 = yil + " yıl ";
            yas1 += ay > 0 ? ay + " ay " : string.Empty;
            yas1 += gun > 0 ? gun + " gun " : string.Empty;
            var resit = ((yil > myil ? MessageBox.Show((adSoyad + " " + yas1 + " "), "GİREBİLİRSİNİZ", MessageBoxButtons.OK, MessageBoxIcon.Information) : MessageBox.Show((adSoyad + " " + yas1 + " "), "GİREMEZSİNİZ", MessageBoxButtons.OK, MessageBoxIcon.Error)));


        }
    }
}
