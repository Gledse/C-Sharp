using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace processar_salarios
{
    public partial class Form1 : Form
    {
        Funcionario func = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void MASCULINO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            string nome = txtNome.Text;
            long contacto = long.Parse(txtContacto.Text);
            int diasTrabalhados = int.Parse(txtDiasTrabalhados.Text);
            int salariosDiarios = int.Parse(txtSalarioDiario.Text);

            string sexo = "";
            if (rbtFemenino.Checked == true) { sexo = rbtFemenino.Text; }
            if (rbtMasculino.Checked == true) { sexo = rbtMasculino.Text; }

            func = new Funcionario(codigo, nome, contacto, sexo, diasTrabalhados,salariosDiarios);

            lstbCodigo.Items.Add(codigo);
            lstbNome.Items.Add(nome);
            lstbContacto.Items.Add(contacto);
            lstbSexo.Items.Add(sexo);
            lstbDiasTrabalhados.Items.Add(diasTrabalhados);
            lstbSalarioDiario.Items.Add(salariosDiarios);

            lstbCodigo.Items.Add(func.getCodigo());
            lstbNome.Items.Add(func.getNome());
            lstbContacto.Items.Add(func.getContacto());
            lstbSexo.Items.Add(func.getSexo());
            lstbDiasTrabalhados.Items.Add(func.getDiasTrabalhados());
            lstbSalarioDiario.Items.Add(func.getSalarioDiario());

            txtCodigo.Text = "";
            txtContacto.Text = "";
            txtDiasTrabalhados.Text = "";
            txtSalarioDiario.Text = "";
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            lstbSalarioMensal.Items.Clear();
            for (int i = 0; i < lstbDiasTrabalhados.Items.Count; i++)
            {

                int dt = int.Parse(lstbDiasTrabalhados.Items[i].ToString());
                int sd = int.Parse(lstbSalarioDiario.Items[i].ToString());
                double salarioMensal = dt * sd;

                lstbSalarioMensal.Items.Add(func.salarioMensal());
            }
        }
    }
}
