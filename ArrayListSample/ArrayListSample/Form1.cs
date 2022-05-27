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

namespace ArrayListSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList arrayList = new ArrayList();

        public void arrayListLoad()
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
            arrayListLoad();
            
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                throw new SpecialException();
            }
            else
            {
                arrayList.Add(textBox1.Text);
                arrayListLoad();
            }
        }
        private void updateBtn_Click(object sender, EventArgs e)
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
                    arrayListLoad();
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("LÜTFEN DEĞİŞTİRİLECEK DEĞERİ SEÇİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var _list = listBox1.SelectedIndex;
                arrayList.Remove(_list);
                arrayListLoad();
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
        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                throw new SpecialException();
            }
            else
            {


                if ((arrayList.Contains(textBox1.Text)) == true)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add(textBox1.Text);
                }
                else
                {
                    MessageBox.Show($"{textBox1.Text} LİSTEDE YOKTUR", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                textBox1.Text = null;
            }
        }
        private void listBtn_Click(object sender, EventArgs e)
        {
            arrayListLoad();
        }

        private void exitBtn_Click(object sender, EventArgs e)
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
