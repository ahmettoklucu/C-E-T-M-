using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool kontrol=true;

        string[] images;
        int image=0;
        int count = 0;
        ArrayList btnarrayList = new ArrayList();

        private void Form1_Load(object sender, EventArgs e)
        {
             images = Directory.GetFiles("..\\..\\Picture");
            int i = 0;
            foreach (var item in images)
            {
                Button button = new Button();
                
                button.Height = button.Width = 68;
                button.Tag = i++;
                button.BackgroundImageLayout = ImageLayout.Stretch;
                button.Image = Image.FromFile(item);
                flowLayoutPanel1.Controls.Add(button);
                btnarrayList.Add(button);
                button.Click += Btn_click;
                image += 1;
            }
        }
        private void Btn_click(object sender, EventArgs e)
        {
            Button clickButton = sender as Button;
            pictureBox1.Image = Image.FromFile(images[Convert.ToInt32(clickButton.Tag)]);
        }

        private void firsBtn_Click(object sender, EventArgs e)
        {
            image = 0;
            pictureBox1.Image = Image.FromFile(images[image]);
        }

        private void lastBtn_Click(object sender, EventArgs e)
        {
            image = images.Length-1;
            pictureBox1.Image = Image.FromFile(images[image]);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            
            image--;
            pictureBox1.Image = Image.FromFile(images[image]);
            if (image == 0)
            {
                image = images.Length-1;
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (image == images.Length - 1)
            {
                image = 0;
            }
            pictureBox1.Image = Image.FromFile(images[image]);
            image++;
        }
        private void raundBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            image = random.Next(0, images.Length-1);
            pictureBox1.Image = Image.FromFile(images[image]);
        }

        private void slideBtn_Click(object sender, EventArgs e)
        {

            if (kontrol)
            {
                sliedBtn.Text = "SLAYTİ DURDUR";
                timer1.Start();
                kontrol = false;
            }
            else
            {
                sliedBtn.Text = "SLAYTİ BAŞLAT";
                timer1.Stop();
                kontrol = true;
            } 
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 700;
            count++;
            pictureBox1.Image = Image.FromFile(images[count]);
            if (count == images.Length-1)
            {
                count = 0;
            }
        }
    }
}
