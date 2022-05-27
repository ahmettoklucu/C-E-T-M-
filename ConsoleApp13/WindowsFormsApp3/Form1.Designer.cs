namespace WindowsFormsApp3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._isimsoyisim = new System.Windows.Forms.TextBox();
            this._yassiniri = new System.Windows.Forms.TextBox();
            this._dTarihi = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İSİM SOYİSİM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DOĞUM TARİHİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "YAŞ SINIRI";
            // 
            // _isimsoyisim
            // 
            this._isimsoyisim.Location = new System.Drawing.Point(95, 18);
            this._isimsoyisim.Name = "_isimsoyisim";
            this._isimsoyisim.Size = new System.Drawing.Size(200, 20);
            this._isimsoyisim.TabIndex = 3;
            // 
            // _yassiniri
            // 
            this._yassiniri.Enabled = false;
            this._yassiniri.Location = new System.Drawing.Point(95, 93);
            this._yassiniri.Name = "_yassiniri";
            this._yassiniri.Size = new System.Drawing.Size(200, 20);
            this._yassiniri.TabIndex = 4;
            // 
            // _dTarihi
            // 
            this._dTarihi.Location = new System.Drawing.Point(95, 62);
            this._dTarihi.Name = "_dTarihi";
            this._dTarihi.Size = new System.Drawing.Size(200, 20);
            this._dTarihi.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 233);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._dTarihi);
            this.Controls.Add(this._yassiniri);
            this.Controls.Add(this._isimsoyisim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _isimsoyisim;
        private System.Windows.Forms.TextBox _yassiniri;
        private System.Windows.Forms.DateTimePicker _dTarihi;
        private System.Windows.Forms.Button button1;
    }
}

