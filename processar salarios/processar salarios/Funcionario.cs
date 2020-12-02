using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processar_salarios
{
   public class Funcionario
    {
       private int codigo, diasTrabalhados;
       private string nome, sexo;
       private long contacto;
       private double salarioDiario;

       public Funcionario(int codigo, string nome, long contacto, string sexo, int diasTrabalhados, double salarioDiario)
       {
           this.codigo = codigo;
           this.nome = nome;
           this.contacto = contacto;
           this.sexo = sexo;
           this.diasTrabalhados = diasTrabalhados;
           this.salarioDiario = salarioDiario;
       }
       public int getCodigo() { return codigo; }
       public string getNome() { return nome; }
       public string getSexo() { return sexo; }
       public long getContacto() { return contacto; }
       public int getDiasTrabalhados() { return diasTrabalhados; }
       public double getSalarioDiario() { return salarioDiario; }
       public double salarioMensal() { return diasTrabalhados * salarioDiario; }
    }
}
