using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitwiseOperations
{
    public partial class Form1 : Form
    {
        Memoria memoria;
        
        public Form1()
        {
            memoria = new Memoria();
            InitializeComponent();
        }

        private void btnAnd_Click(object sender, EventArgs e)
        {
            lblResultado.Text = memoria.AND(txbInput1.Text, txbInput2.Text);
        }

        private void btnOR_Click(object sender, EventArgs e)
        {
            lblResultado.Text = memoria.OR(txbInput1.Text, txbInput2.Text);
        }
        

        private void btnXOR_Click(object sender, EventArgs e)
        {
            lblResultado.Text = memoria.XOR(txbInput1.Text, txbInput2.Text);
        }
        private void btnNOT_Click(object sender, EventArgs e)
        {
            lblResultado.Text = memoria.NOT(txbInput1.Text, txbInput2.Text);
        }

        private void btnRShift_Click(object sender, EventArgs e)
        {
            lblResultado.Text = memoria.RShift(txbInput1.Text, txbInput2.Text);
        }

        private void btnLShift_Click(object sender, EventArgs e)
        {
            lblResultado.Text = memoria.LShift(txbInput1.Text, txbInput2.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbInput1.Clear();
            txbInput2.Clear();
            lblResultado.Text = "Resultado";
        }

    }
}
