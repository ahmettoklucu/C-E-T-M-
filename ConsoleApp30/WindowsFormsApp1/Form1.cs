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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            bool b = sender.GetType() //sender tiklanan değer tiklanan nesnin tipi //GetType tiklanan nesnenin tipini döndürür
               == typeof(Button);
            MessageBox.Show($"verinin tipi buton değildir{b}");

        }

        private void button1_Click(object sender, EventArgs e)
        {
          bool b = sender.GetType() //sender tiklanan nesne /GetType tiklanan nesnenin tipini döndürür
                == typeof(Button);
            MessageBox.Show( $"verinin tipi buttondur {b}");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool _deger = sender is Button;
            MessageBox.Show($"gelen nesnenin tipi buttondur {_deger}");

        }
    }
}
