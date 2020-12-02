using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Pofessor
{
    public partial class FormularioDoProfessor : Form
    {
        Professor ListaProfessor = null;
        public FormularioDoProfessor()
        {
            InitializeComponent();
        }

        
        private void btnAdicionarLIstas_Click(object sender, EventArgs e)
        {


            int codigo = int.Parse(txtCodigo.Text);
            string nome = txtNome.Text;
            int contacto = int.Parse(txtContacto.Text);
            string nivel = cboNivel.Text;
            string curso = cboCurso.Text;

            int HorasTrabalhadasMes = int.Parse(Console.ReadLine());
            double salarioHora = double.Parse(Console.ReadLine());

            ListaProfessor = new Professor(codigo, nome, contacto, curso, nivel, HorasTrabalhadasMes, salarioHora);

            lstbCodigo.Items.Add(codigo);
            lstbNome.Items.Add(nome);
            lstbContacto.Items.Add(contacto);
            lstbCurso.Items.Add(curso);
            lstbNivel.Items.Add(nivel);

            lstbCodigo.Items.Add(ListaProfessor.getCodigo());
            lstbNome.Items.Add(ListaProfessor.nome);
            lstbContacto.Items.Add(ListaProfessor.getContacto());
            lstbCurso.Items.Add(ListaProfessor.curso);
            lstbNivel.Items.Add(ListaProfessor.nivel);

            txtCodigo.Text = "";
            txtContacto.Text = "";
            cboCurso.Text = "";
            cboNivel.Text = "";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtContacto.Text = "";
            cboCurso.Text = "";
            cboNivel.Text = "";
        }

        private void btnListarProfessores_Click(ArrayList ListaProfessor, object sender, EventArgs e)
        {
            
            string nome = txtNome.Text;
            string curso = cboCurso.Text;

            foreach (Professor prof in ListaProfessor)
            {
                if ((nome).Equals(prof.nome) && ((curso).Equals(prof.curso)))
                {
                    prof.imprimir();
                }
            }
        }

        private void btnListarLicenciados_Click(ArrayList ListaProfessor, object sender, EventArgs e)
        {

            string nome = txtNome.Text;
            string nivel = cboNivel.Text;

            foreach (Professor prof in ListaProfessor)
            {
                if ((nome).Equals(prof.nome) && (nivel).Equals("Licenciado"))
                {
                    prof.imprimir();
                }
            }
        }
    }
}
