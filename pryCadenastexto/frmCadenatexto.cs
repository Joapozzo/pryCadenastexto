using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCadenastexto
{
    public partial class frmCadenas : Form
    {
        public frmCadenas()
        {
            InitializeComponent();
        }

        private void btnLowerCase_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtTex.Text.ToLower());
        }

        private void btnUppercase_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtTex.Text.ToUpper());

        }

        private void btnSinespacios_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtTex.Text.Trim());

        }

        private void btnMayorMenor_Click(object sender, EventArgs e)
        {
            if (txtTex.Text.Length > txtText2.Text.Length)
            {
                MessageBox.Show(txtTex.Text + " Es mas largo");
            }
            else
            {
                MessageBox.Show(txtText2.Text + " Es mas largo");
            }
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            
        }
    }
}
