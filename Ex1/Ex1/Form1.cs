using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtValorA.Text);
            double b = double.Parse(txtValorB.Text);
            double c = double.Parse(txtValorC.Text);

            if ((a != 0))
            {
               /* if( (a == null) ){
                    a = 1;

                }*/
                double d = Math.Pow(-b, 2) - 4 * a * c;
                txtDelta.Text = d + "";
                
                if ((d >= 0))
                {
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    txtValorX1.Text = x1 + "";

                    double x2 = (-b - Math.Sqrt(d)) /( 2 * a);
                    txtValorX2.Text = x2 + "";

                } else { MessageBox.Show("A funcao nao tem raizes reias"); }
            }else { MessageBox.Show("Valor invalido, A e B tem de ser diferente de 0"); }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValorA.Text = "";
            txtValorB.Text = "";
            txtValorC.Text = "";
            txtDelta.Text = "";
            txtValorX1.Text = "";
            txtValorX2.Text = "";

        }
    }
}
