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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Overlod");
            MessageBox.Show("3.Overload", "Merhaba");
            MessageBox.Show("5.oveload", "Merhaba", MessageBoxButtons.YesNoCancel);
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("6.oveload", "merhaba", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            MessageBox.Show("7.overload", "merhaba", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("yazılacak metin", "başlik", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error,MessageBoxDefaultButton.Button2);
            string message = null;
            switch (dialogResult)
            {
                case DialogResult.Cancel:message = "İPTAL"; break;
                case DialogResult.Yes:message = "EVET";break;
                case DialogResult.No:message = "HAYİR";break;
            }
            MessageBox.Show($"{message}TUŞUNA BASTINIZ");
        }
    }
}
