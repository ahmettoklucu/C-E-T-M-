using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "GÜNLER";
            button1.Text = "VERİ GÜNCELLE";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] haftaGunleri = { "PAZARTESİ", "SALİ", "ÇARŞAMBA", "PERŞEMBE", "CUMA", "CUMARTESİ", "PAZARTESİ" };
            string[] aylar = { "OCAK", "ŞUBAT", "MART", "NİSAN", "MAYİS", "HAZİRAN", "TEMMUZ", "AĞUSTOS", "EYLÜL", "EKİM", "KASİM", "ARALIK" };
            comboBox1.Items.AddRange(haftaGunleri);//AddRange toplu eklemedir
            listBox1.Items.AddRange(aylar);
            foreach(Control control in Controls)//bütün itemlere uygulanır.
            {
                control.BackColor = Color.DarkBlue;
                control.ForeColor = Color.Yellow;
            }
        }
    }
}
