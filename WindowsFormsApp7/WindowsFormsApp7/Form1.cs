using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1;
            double s2;
            bool tx = double.TryParse(textBox1.Text, out double result);
            bool ty = double.TryParse(textBox2.Text, out double result1);
            if (tx && ty)
            {
                s1 = Convert.ToDouble(textBox1.Text);
                s2 = Convert.ToDouble(textBox2.Text);
                if (radioButton1.Checked==true)
                {
                    MessageBox.Show(Convert.ToString(s1+s2));
                }
                else if (radioButton2.Checked==true)
                {
                    MessageBox.Show(Convert.ToString(s1 - s2));
                }
                else if (radioButton3.Checked==true)
                {
                    MessageBox.Show(Convert.ToString(s1 * s2));
                }
                else
                {
                    MessageBox.Show(Convert.ToString(s1 / s2));
                }
            }
        }
    }
}
