namespace DataGridView
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.snameTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.snameLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(13, 13);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(486, 324);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvData_CellMouseClick);
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(565, 23);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(100, 20);
            this.idTxt.TabIndex = 1;
            this.idTxt.TextChanged += new System.EventHandler(this.idTxt_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // snameTxt
            // 
            this.snameTxt.Location = new System.Drawing.Point(565, 143);
            this.snameTxt.Name = "snameTxt";
            this.snameTxt.Size = new System.Drawing.Size(100, 20);
            this.snameTxt.TabIndex = 3;
            this.snameTxt.TextChanged += new System.EventHandler(this.snameTxt_TextChanged);
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(565, 86);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(100, 20);
            this.nameTxt.TabIndex = 4;
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // snameLbl
            // 
            this.snameLbl.AutoSize = true;
            this.snameLbl.Location = new System.Drawing.Point(505, 150);
            this.snameLbl.Name = "snameLbl";
            this.snameLbl.Size = new System.Drawing.Size(51, 13);
            this.snameLbl.TabIndex = 5;
            this.snameLbl.Text = "SOYİSİM";
            this.snameLbl.Click += new System.EventHandler(this.snameLbl_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(505, 93);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(29, 13);
            this.nameLbl.TabIndex = 6;
            this.nameLbl.Text = "İSİM";
            this.nameLbl.Click += new System.EventHandler(this.nameLbl_Click);
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(505, 30);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(29, 13);
            this.idLbl.TabIndex = 7;
            this.idLbl.Text = "İSİM";
            this.idLbl.Click += new System.EventHandler(this.idLbl_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(590, 314);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "EKLE";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 359);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.snameLbl);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.snameTxt);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.dgvData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox snameTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label snameLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Button addBtn;
    }
}

