using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pofessor
{
    class Professor
    {
        
        private int codigo;
        public string nome;
        private int contacto;
        public string curso;
        public string nivel;
        private int horasTrabalhadasMes;
        private double salarioHora;

        public Professor(int codigo, string nome, int contacto, string curso, string nivel, int horasTrabalhadasMes, double salarioHora)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.contacto = contacto;
            this.curso = curso;
            this.nivel = nivel;
            this.horasTrabalhadasMes = horasTrabalhadasMes;
            this.salarioHora = salarioHora;
        }
        public Professor() { }

        public void setCodigo(int codigo) { this.codigo = codigo; }
        public void setContacto(int contacto) { this.contacto = contacto; }
        public void setHorasTrabalhadasMes(int horas) { this.horasTrabalhadasMes = horas; }
        public void setSalarioHora(double salario) { this.salarioHora = salario; }

        public int getCodigo() { return codigo; }
        public int getContacto() { return contacto; }
        public int getHorasTrabalhadasMes() { return horasTrabalhadasMes; }
        public double getSalarioHora() { return salarioHora; }

        
        public String toString() 
        {
            return   "Codigo = "+ codigo +", Nome = "+ nome +", Contacto = "+ contacto
                + ", Curso = "+ curso +", nivel = "+ nivel +", horasTrabalhadasMes = "+ horasTrabalhadasMes +"e salarioHora = "+ salarioHora;
        }
        public double salarioProfessor()
        {
            double s;
            return s = salarioHora * horasTrabalhadasMes;
        }
        public void imprimir() 
        {
            Console.WriteLine(toString(),salarioProfessor()); 
        }
    }
}
