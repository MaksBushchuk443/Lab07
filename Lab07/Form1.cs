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
                tbY.Text = "Не введеноданих!";
                return;
            }
            double x1 = double.Parse(tbX0.Text);
            double x2 = double.Parse(tbX2.Text);
            double y = Math.Sqrt(56 * x1 * ( x1+ x2 + Math.Sin(x1 * x2)) / 5 - Math.Cos(Math.Pow(x2,2))  );
            tbY.Text = y.ToString("0.###");
            if (x2 == x1)
                txbAvr.Text = "Значення рівні";
            else if (x2 > x1)
                txbAvr.Text = x1.ToString("0.###");
            else
                txbAvr.Text = x2.ToString("0.###");
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
    }
}
