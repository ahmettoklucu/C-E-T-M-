using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
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
            bool tx = int.TryParse(textBox1.Text, out int result);
            bool ty = int.TryParse(textBox2.Text, out int result2);
            if (tx && ty)
            {
                sayi1 = Convert.ToInt32(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);

                switch (textBox3.Text)
                {
                    case "+":label4.Text = Convert.ToString(sayi1 + sayi2); break;
                    case "-": label4.Text = Convert.ToString(sayi1 - sayi2); break;
                    case "*": label4.Text = Convert.ToString(sayi1 * sayi2); break;
                    case "/":
                        if (sayi2 == 0)
                        {
                            MessageBox.Show("Hiçbir sayi 0 a bölünemez", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else
                        { 
                        double s1 = Convert.ToDouble(sayi1);
                        double s2 = Convert.ToDouble(sayi2);

                        label4.Text = Convert.ToString(s1 / s2);
                            break;
                        }
                }

            }
            else
            {
                MessageBox.Show("LÜTFEN SAYİSAL BİR DEĞER GİRİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
