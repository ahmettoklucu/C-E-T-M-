using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soru_no = 0, dogru = 0, yanlis = 0;
        string _cevap;

        private void aBtn_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = Color.Yellow;
            hrfBtn.Text = button.Text;
        }
        private void bBtn_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = Color.Yellow;
            hrfBtn.Text = button.Text;
        }
        private void cBtn_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = Color.Yellow;
            hrfBtn.Text = button.Text; ;
        }
        private void dBtn_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = Color.Yellow;
            hrfBtn.Text = button.Text;
        }
        private void eBtn_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = Color.Yellow;
            hrfBtn.Text = button.Text;

        }
        private void fBtn_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = Color.Yellow;
            hrfBtn.Text = button.Text;
        }
        private void gBtn_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = Color.Yellow;
            hrfBtn.Text = button.Text;
        }
        private void hBtn_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = Color.Yellow;
            hrfBtn.Text = button.Text;
        }
        private void iBtn_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = Color.Yellow;
            hrfBtn.Text = button.Text;
        }
        private void jBtn_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = Color.Yellow;
            hrfBtn.Text = button.Text;
        }
        private void kBtn_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = Color.Yellow;
            hrfBtn.Text = button.Text;
        }
        private void lBtn_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = Color.Yellow;
            hrfBtn.Text = button.Text;
        }
        private void mBtn_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = Color.Yellow;
            hrfBtn.Text = button.Text;
        }
        private void nBtn_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = Color.Yellow;
            hrfBtn.Text = button.Text;
        }
        private void oBtn_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = Color.Yellow;
            hrfBtn.Text = button.Text;
        }
        private void pBtn_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = Color.Yellow;
            hrfBtn.Text = button.Text;
        }
        private void rBtn_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = Color.Yellow;
            hrfBtn.Text = button.Text;
        }
        private void sBtn_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = Color.Yellow;
            hrfBtn.Text = button.Text;
        }
        private void tBtn_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = Color.Yellow;
            hrfBtn.Text = button.Text;
        }

        private void Ctrl(string x,Button button,string _cevap)
        {
            if (_cevap == x)
            {
                button.BackColor = Color.Green;
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                button.BackColor = Color.Red;
                yanlis++;
                label3.Text = yanlis.ToString();

            }
            
        }
      

      

        private void uBtn_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = Color.Yellow;
            hrfBtn.Text = button.Text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            soru_no++;
            linkLabel1.Text = "SONRAKİ";
            this.Text = soru_no.ToString();//ÜSTTEKİ SAYİ DEĞİŞİYOR FORM1 YAZAN YER
            if (soru_no == 1)
            {
                textBox1.Enabled = true;
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi.";
                hrfBtn.Text = aBtn.Text;
                aBtn.BackColor = Color.Yellow;
            }
            else if (soru_no == 2)
            {
                richTextBox1.Text = "Yeşilliği ile ünlü olan marmara ilimiz?";
                hrfBtn.Text = bBtn.Text;
                bBtn.BackColor = Color.Yellow;
            }
            else if (soru_no == 3)
            {
                richTextBox1.Text = "Müslümanlarin kutsal günü";
                hrfBtn.Text = cBtn.Text;
                cBtn.BackColor = Color.Yellow;
            }
            else if (soru_no == 4)
            {
                richTextBox1.Text = "Karpuzu ile ünlü ilimiz";
                hrfBtn.Text = dBtn.Text;
                dBtn.BackColor = Color.Yellow;
            }
            else if (soru_no == 5)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındakı kıyı bölgesi";
                hrfBtn.Text = eBtn.Text;
                eBtn.BackColor = Color.Yellow;
            }
            else if (soru_no == 6)
            {
                richTextBox1.Text = "Türkiyenin en büyük takımı";
                hrfBtn.Text = fBtn.Text;
                fBtn.BackColor = Color.Yellow;
            }
            else if (soru_no == 7)
            {
                richTextBox1.Text = "Dünyanın isi kaynaği";
                hrfBtn.Text = gBtn.Text;
                gBtn.BackColor = Color.Yellow;
            }
            else if (soru_no == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirdiklerinde baktığı yer";
                hrfBtn.Text = hBtn.Text;
                hBtn.BackColor = Color.Yellow;
            }
            else if (soru_no == 9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz";
                hrfBtn.Text = iBtn.Text;
                iBtn.BackColor = Color.Yellow;
            }
            else if (soru_no == 10)
            {
                richTextBox1.Text = "Askeri bir topluluk";
                hrfBtn.Text = jBtn.Text;
                jBtn.BackColor = Color.Yellow;
            }
            else if (soru_no == 11)
            {
                richTextBox1.Text = "Malatyanın meşhur meyvesi";
                hrfBtn.Text = kBtn.Text;
                kBtn.BackColor = Color.Yellow;
            }
            else if (soru_no == 12)
            {
                richTextBox1.Text = "Her yil bahar aylarinda düzenlenen çiçek festivali";
                hrfBtn.Text = lBtn.Text;
                lBtn.BackColor = Color.Yellow;
            }
            else if (soru_no == 13)
            {
                richTextBox1.Text = "Yilin üçüncu ayı";
                hrfBtn.Text = mBtn.Text;
                mBtn.BackColor = Color.Yellow;
            }
            else if (soru_no == 14)
            {
                richTextBox1.Text = "Üflemeli bir müzik aleti?";
                hrfBtn.Text = nBtn.Text;
                nBtn.BackColor = Color.Yellow;
            }
            else if (soru_no == 15)
            {
                richTextBox1.Text = "Halk şairi";
                hrfBtn.Text = oBtn.Text;
                oBtn.BackColor = Color.Yellow;
            }
            else if (soru_no == 16)
            {
                richTextBox1.Text = "Çocuklarin pek sevmediği pirinç havuç gibi nesnelerden yapılan yemek";
                hrfBtn.Text = pBtn.Text;
                pBtn.BackColor = Color.Yellow;
            }
            else if (soru_no == 17)
            {
                richTextBox1.Text = "11 ayın sultani";
                hrfBtn.Text = rBtn.Text;
                rBtn.BackColor = Color.Yellow;
            }
            else if (soru_no == 18)
            {
                richTextBox1.Text = "İngilizcede yilan";
                hrfBtn.Text = sBtn.Text;
                sBtn.BackColor = Color.Yellow;
            }
            else if (soru_no == 19)
            {
                richTextBox1.Text = "türkiyenin mega stari";
                hrfBtn.Text = tBtn.Text;
                tBtn.BackColor = Color.Yellow;
            }
            else if (soru_no == 20)
            {
                richTextBox1.Text = ("Ümit kelimesinin eş anlamlisi");
                hrfBtn.Text = uBtn.Text;
                uBtn.BackColor = Color.Yellow;
            }
            else if (soru_no == 21)
            {
                richTextBox1.Text = ("Kahvaltisi ile ünlü ilimiz");
                hrfBtn.Text = vBtn.Text;
                vBtn.BackColor = Color.Yellow;
            }
            else if (soru_no == 22)
            {
                richTextBox1.Text = ("Şimşek kelimesinin eş anlamlisi");
                hrfBtn.Text = yBtn.Text;
                yBtn.BackColor = Color.Yellow;
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)//ENTER İLE YAPILAN
                {
                    textBox1.Enabled = false;
                    switch (soru_no)
                    {
                    case 1:
                            _cevap = textBox1.Text.ToUpper();
                            Ctrl(_cevap, aBtn, "AKDENİZ");
                            break;
                    case 2:
                        _cevap = textBox1.Text.ToUpper();
                        Ctrl(_cevap, bBtn, "AKDENİZ");
                        break;
                    case 3:
                        _cevap = textBox1.Text.ToUpper();
                        Ctrl(_cevap, cBtn, "AKDENİZ");
                        break;
                    case 4:
                        _cevap = textBox1.Text.ToUpper();
                        Ctrl(_cevap, dBtn, "AKDENİZ");
                        break;
                    case 5:
                        _cevap = textBox1.Text.ToUpper();
                        Ctrl(_cevap, eBtn, "AKDENİZ");
                        break;
                    case 6:
                        _cevap = textBox1.Text.ToUpper();
                        Ctrl(_cevap, fBtn, "AKDENİZ");
                        break;
                    case 7:
                        _cevap = textBox1.Text.ToUpper();
                        Ctrl(_cevap, gBtn, "AKDENİZ");
                        break;
                    case 8:
                        _cevap = textBox1.Text.ToUpper();
                        Ctrl(_cevap, hBtn, "AKDENİZ");
                        break;
                    case 9:
                        _cevap = textBox1.Text.ToUpper();
                        Ctrl(_cevap, iBtn, "AKDENİZ");
                        break;
                    case 10:
                        _cevap = textBox1.Text.ToUpper();
                        Ctrl(_cevap, jBtn, "AKDENİZ");
                        break;
                    case 11:
                        _cevap = textBox1.Text.ToUpper();
                        Ctrl(_cevap, kBtn, "AKDENİZ");
                        break;
                    case 12:
                        _cevap = textBox1.Text.ToUpper();
                        Ctrl(_cevap, lBtn, "AKDENİZ");
                        break;
                    case 13:
                        _cevap = textBox1.Text.ToUpper();
                        Ctrl(_cevap, mBtn, "AKDENİZ");
                        break;
                    case 14:
                        _cevap = textBox1.Text.ToUpper();
                        Ctrl(_cevap, nBtn, "AKDENİZ");
                        break;
                    case 15:
                        _cevap = textBox1.Text.ToUpper();
                        Ctrl(_cevap, oBtn, "AKDENİZ");
                        break;
                    case 16:
                        _cevap = textBox1.Text.ToUpper();
                        Ctrl(_cevap, pBtn, "AKDENİZ");
                        break;
                    case 17:
                        _cevap = textBox1.Text.ToUpper();
                        Ctrl(_cevap, rBtn, "AKDENİZ");
                        break;
                    case 18:
                        _cevap = textBox1.Text.ToUpper();
                        Ctrl(_cevap, sBtn, "AKDENİZ");
                        break;
                    case 19:
                        _cevap = textBox1.Text.ToUpper();
                        Ctrl(_cevap, tBtn, "AKDENİZ");
                        break;



                }
                }
        }

    }

     
}

