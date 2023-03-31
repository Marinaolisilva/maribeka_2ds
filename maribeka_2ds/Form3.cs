using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maribeka_2ds
{
    public partial class frmtabu : Form
    {
        public frmtabu()
        {
            InitializeComponent();
        }

        private void frmtabu_Load(object sender, EventArgs e)
        {

        }

        private void btnrepita_Click(object sender, EventArgs e)
        {
            int num, i, result;
            

            num = Convert.ToInt32(txtnum.Text);

            i = 1;

            do
            {
                result = num * i;
                txtresult.Text = String.Concat(txtresult.Text,"\r\n", result.ToString());

                i++;
            } while (i <= 10);
            
        }

        private void btnpara_Click(object sender, EventArgs e)
        {
            double num, result;
            int i;

            num = Convert.ToDouble(txtnum.Text);

            for (i = 1; i <= 10; i++)
            {
                result = num * i;
                txtresult.Text = String.Concat(txtresult.Text, "\r\n", result.ToString());
            }
        }

        private void btnenquanto_Click(object sender, EventArgs e)
        {
            double num, result;
            int i;
            
            num = Convert.ToDouble(txtnum.Text);

            i = 1;

            while (i <= 10)
            {
                result = num * i;
                txtresult.Text = String.Concat(txtresult.Text, "\r\n", result.ToString());
                i++;
            }

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu frm= new frmmenu();
            frm.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresult.Clear();

            txtnum.Focus();
        }
    }
}
