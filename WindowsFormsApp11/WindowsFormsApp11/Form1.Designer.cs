namespace WindowsFormsApp11
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.firsBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.raundBtn = new System.Windows.Forms.Button();
            this.sliedBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.lastBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(182, 425);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(201, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 368);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // firsBtn
            // 
            this.firsBtn.Location = new System.Drawing.Point(201, 387);
            this.firsBtn.Name = "firsBtn";
            this.firsBtn.Size = new System.Drawing.Size(77, 51);
            this.firsBtn.TabIndex = 2;
            this.firsBtn.Text = "İLK";
            this.firsBtn.UseVisualStyleBackColor = true;
            this.firsBtn.Click += new System.EventHandler(this.firsBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(605, 387);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(77, 51);
            this.nextBtn.TabIndex = 3;
            this.nextBtn.Text = "SONRA";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // raundBtn
            // 
            this.raundBtn.Location = new System.Drawing.Point(367, 387);
            this.raundBtn.Name = "raundBtn";
            this.raundBtn.Size = new System.Drawing.Size(113, 51);
            this.raundBtn.TabIndex = 4;
            this.raundBtn.Text = "RASTGELE";
            this.raundBtn.UseVisualStyleBackColor = true;
            this.raundBtn.Click += new System.EventHandler(this.raundBtn_Click);
            // 
            // sliedBtn
            // 
            this.sliedBtn.Location = new System.Drawing.Point(486, 387);
            this.sliedBtn.Name = "sliedBtn";
            this.sliedBtn.Size = new System.Drawing.Size(113, 51);
            this.sliedBtn.TabIndex = 5;
            this.sliedBtn.Text = "SLAYT";
            this.sliedBtn.UseVisualStyleBackColor = true;
            this.sliedBtn.Click += new System.EventHandler(this.slideBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(284, 387);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(77, 51);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "ÖNCE";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // lastBtn
            // 
            this.lastBtn.Location = new System.Drawing.Point(688, 387);
            this.lastBtn.Name = "lastBtn";
            this.lastBtn.Size = new System.Drawing.Size(77, 51);
            this.lastBtn.TabIndex = 7;
            this.lastBtn.Text = "SON";
            this.lastBtn.UseVisualStyleBackColor = true;
            this.lastBtn.Click += new System.EventHandler(this.lastBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.lastBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.sliedBtn);
            this.Controls.Add(this.raundBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.firsBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button firsBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button raundBtn;
        private System.Windows.Forms.Button sliedBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button lastBtn;
        private System.Windows.Forms.Timer timer1;
    }
}

