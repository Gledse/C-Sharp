using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Edson
{
    class MetodosDoEstudante
    {
       

        public static ArrayList addEstudante()
        {
            ArrayList lista = new ArrayList();

            Console.WriteLine("Digite a quantidade de estudantes que deseja registrar");
            int cap = int.Parse(Console.ReadLine());

            for(int i = 1; i <= cap; i++)
            {
                 System.Console.WriteLine("Digite o nome");
                 string nome = System.Console.ReadLine();

                System.Console.WriteLine("Digite o curso");
                string curso = System.Console.ReadLine();

                System.Console.WriteLine("Digite o teste 1");
                double teste1 = double.Parse(System.Console.ReadLine());

                System.Console.WriteLine("Digite o teste 2");
                double teste2 = double.Parse(System.Console.ReadLine());

                lista.Add(new Estudante(nome, curso, teste1, teste2));
            }
            return lista;
        }

        public static void listaAgrupadaDeEstudante(ArrayList lista)
        {
            System.Console.WriteLine("Digite o nome");
            string nome = System.Console.ReadLine();

            foreach (Estudante est in lista)
            {
                if(est.getNome().Equals(nome))
                {
                    if (est.calcularMedia() >= 0 && est.calcularMedia() <= 9)
                    {
                        System.Console.WriteLine(est.toString());
                        System.Console.WriteLine(est.calcularMedia() + " Excluido");
                    }
                    if (est.calcularMedia() >= 10 && est.calcularMedia() < 13.5)
                    {
                        System.Console.WriteLine(est.toString());
                        System.Console.WriteLine(est.calcularMedia() + " Admitido");
                    }
                    if (est.calcularMedia() >= 13.5 && est.calcularMedia() <= 20)
                    {
                        System.Console.WriteLine(est.toString());
                        System.Console.WriteLine(est.calcularMedia()+" Dispensado");
                    }  
                }
            }
        }

        public static void pelomenosUmaNotaNegativa(ArrayList lista)
        {
            foreach (Estudante est in lista)
            {
                if (est.getTeste1() <= 9 || est.getTeste2() <= 9)
                {
                    System.Console.WriteLine(est.toString());
                }
            }
        }

        public static void actualizarEstudanteComNegativas(ArrayList lista)
        {
            foreach (Estudante est in lista)
            {
                if (est.getTeste1() <= 9 || est.getTeste2() <= 9 && est.getCurso().Equals("Informatica"))
                {
                    System.Console.WriteLine("Digite o teste 1");
                    est.setTeste1(double.Parse(System.Console.ReadLine()));

                    System.Console.WriteLine("Digite o teste 2");
                    est.setTeste2(double.Parse(System.Console.ReadLine()));

                    lista.Add(est);
                }
            }
        }
    }
}
