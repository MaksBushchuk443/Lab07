using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbX0.Text) || (String.IsNullOrEmpty(tbX2.Text)))
            {
                tbY.Text = "Не введено даних!";
                return;
            }
            double x1 = double.Parse(tbX0.Text);
            double x2 = double.Parse(tbX2.Text);
            double y = 23 * Math.Pow(Math.Cos(Math.Pow(x1, 3) * Math.Pow(x2, 5)), 2) + 2 * x1;
            tbY.Text = y.ToString("0.####");

            double s = (x1 + x2) / 2  ;
            txbAvr.Text = s.ToString("0.####");
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbX0.Text = string.Empty;
            tbX2.Text = string.Empty;
            tbY.Text = string.Empty;
            txbAvr.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbX0_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
