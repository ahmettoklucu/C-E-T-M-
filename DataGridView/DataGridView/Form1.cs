using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int row = dgvData.Rows.Add();
            dgvData.Rows[row].Cells[0].Value = idTxt.Text;
            dgvData.Rows[row].Cells[1].Value = nameTxt.Text;
            dgvData.Rows[row].Cells[2].Value = snameTxt.Text;
        }

        private void dgvData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            idTxt.Text =Convert.ToString(dgvData.CurrentRow.Cells[0].Value);
            nameTxt.Text = Convert.ToString(dgvData.CurrentRow.Cells[1].Value);
            snameTxt.Text = Convert.ToString(dgvData.CurrentRow.Cells[2].Value);

        }
        private void txtClean()
        {
            idTxt.Clear();
            nameTxt.Clear();
            snameTxt.Clear();

        }

        private void idTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void snameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void idLbl_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nameLbl_Click(object sender, EventArgs e)
        {

        }

        private void snameLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
