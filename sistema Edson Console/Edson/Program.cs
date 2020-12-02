using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edson
{
    class Estudante
    {
        private string nome;
        private string curso;
        private double teste1;
        private double teste2;

        public Estudante() { }
        public Estudante(string nome, string curso, double teste1, double teste2) 
        {
            this.nome = nome;
            this.curso = curso;
            this.teste1 = teste1;
            this.teste2 = teste2;
        }

        public string getNome() { return nome; }
        public string getCurso() { return curso; }
        public double getTeste1() { return teste1; }
        public double getTeste2() { return teste2; }

        public void setNome(string nome) { this.nome = nome; }
        public void setCurso(string curso) { this.curso = curso; }
        public void setTeste1(double teste1) { this.teste1 = teste1; }
        public void setTeste2(double teste2) { this.teste2 = teste2; }

        public string toString()
        {
            return "Nome: " + nome + " Curso: " + curso + " Teste 1: " + teste1 + " Teste 2: " + teste2;
        }
        public double calcularMedia()
        {
            return (this.teste1 + this.teste2) / 2;
        }
    }
}
