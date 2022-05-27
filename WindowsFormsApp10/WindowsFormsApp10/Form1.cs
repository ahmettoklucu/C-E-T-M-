using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList arrayList = new ArrayList();
        public void arrayLislLoad()
        {
            listBox1.Items.Clear();
            foreach (var item in arrayList)
            {
                listBox1.Items.Add(item);
            }
            textBox1.Text = null;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            arrayLislLoad();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                throw new SpecialException();
            }
            else
            {
                arrayList.Add(textBox1.Text);
                arrayLislLoad();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var _list = listBox1.SelectedIndex;
                arrayList.RemoveAt(_list);
                listBox1.Items.Clear();
                foreach (var item in arrayList)
                {
                    listBox1.Items.Add(item);
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("LÜTFEN SİLİNECEK DEĞERİ SEÇİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                textBox1.Text = null;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == null)
                {
                    throw new SpecialException();
                }
                else
                {
                    var _list = listBox1.SelectedIndex;
                    arrayList[_list] = textBox1.Text;
                    arrayLislLoad();
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("LÜTFEN DEĞİŞTİRİLECEK DEĞERİ SEÇİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                throw new SpecialException();
            }
            else
            {

                if ((arrayList.Contains(textBox1.Text)) == true)
                {
                    var sİndex = arrayList.IndexOf(textBox1.Text);
                    listBox1.Items.Clear();
                    listBox1.Items.Add(textBox1.Text);
                    MessageBox.Show($"aradiğin değer dizinin {sİndex + 1}", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{textBox1.Text} LİSTEDE YOKTUR", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                textBox1.Text = null;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {   
            arrayList.Sort();
            arrayLislLoad();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }
    }
}


