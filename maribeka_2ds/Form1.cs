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
    public partial class frmposto : Form
    {
        public frmposto()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double comb, litro, result;

            comb = Convert.ToChar(txtcomb.Text);
            litro = Convert.ToDouble(txtlitro.Text);

            if (comb == 'A')
            {
                if (litro <= 20)
                {
                    result = litro * (4.30 - (4.30 * 3 / 100));
                    txtresult.Text = result.ToString();
                }

                else if (litro>20) {
                    result = litro * (4.30 - (4.30 * 5 / 100));
                    txtresult.Text = result.ToString();
                }
            }

            else if (comb == 'G')
            {
                if (litro <= 20)
                {
                    result = litro * (5.50 - (5.50 * 4 / 100));
                    txtresult.Text = result.ToString();
                }
                else if (litro > 20)
                {
                    result = litro * (5.50 - (5.50 * 6 / 100));
                    txtresult.Text = result.ToString();
                }
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcomb.Clear();
            txtlitro.Clear();
            txtresult.Clear();

            txtcomb.Focus();

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu frm = new frmmenu ();
            frm.Show();
        }
    }
}
