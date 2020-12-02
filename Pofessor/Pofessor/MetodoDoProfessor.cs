using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Pofessor
{
    class MetodosDoProfessor
    {
        public static ArrayList addProfessor()
        {
            ArrayList ListaProfessor = new ArrayList();

            Console.WriteLine("Digite a capacidade de professores que deseja registrar");
            int cap = int.Parse(Console.ReadLine());

            for (int i = 0; i <= cap; i++)
            {
                Console.WriteLine("Introduza o codigo");
                int codigo = int.Parse(Console.ReadLine());

                Console.WriteLine("Introduza o nome ");
                string nome = Console.ReadLine();

                Console.WriteLine("Introduza o contacto ");
                int contacto = int.Parse(Console.ReadLine());

                Console.WriteLine("Introduza o curso ");
                string curso = Console.ReadLine();

                Console.WriteLine("Medio, " + "Licenciado, " + " Mestre e" + " Dotour");
                Console.WriteLine(" Escreva um dos niveis");
                string nivel = Console.ReadLine();

                Console.WriteLine("Introduza o numero de horas trabalhadas em determinado mes ");
                int HorasTrabalhadasMes = int.Parse(Console.ReadLine());

                Console.WriteLine("Introduza o valor que o professor recebe por hora");
                double salarioHora = double.Parse(Console.ReadLine());

                ListaProfessor.Add(new Professor(codigo, nome, contacto, curso, nivel, HorasTrabalhadasMes, salarioHora));    
            }
            
            return ListaProfessor;
        }
        public void imprimirPofessor(ArrayList ListaProfessor)
        {
            Console.WriteLine("Introduza o nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Introduza o curso");
            string curso = Console.ReadLine();

            foreach (Professor prof in ListaProfessor)
            {
                if ((nome).Equals(prof.nome) && ((curso).Equals(prof.curso)))
                {
                    prof.imprimir();
                } 
            }
        }
        public static void pesquisarPorNivel(ArrayList ListaProfessor)
        {
            Console.WriteLine("Introduza o nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Medio, " + "Licenciado, " + " Mestre e" + " Dotour");
            Console.WriteLine("Introduza o nivel que pretende pesquisar");
            string nivel = Console.ReadLine();

            foreach (Professor prof in ListaProfessor)
            {
                if ((nome).Equals(prof.nome) && (nivel).Equals("Medio"))
                {
                    prof.imprimir();
                }
                else if ((nome).Equals(prof.nome) && (nivel).Equals("Licenciado"))
                {
                    prof.imprimir();
                }
                else if ((nome).Equals(prof.nome) && (nivel).Equals("Mestre"))
                {
                    prof.imprimir();
                }
                else if ((nome).Equals(prof.nome) && (nivel).Equals("Dotour"))
                {
                    prof.imprimir();
                }
            }
        }
        public static void atualizarNivel(ArrayList ListaProfessor)
        {
            Console.WriteLine("Introduza o nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Introduza o curso");
            string curso = Console.ReadLine();

            foreach (Professor prof in ListaProfessor)
            {
                if ((nome).Equals(prof.nome) && ((curso).Equals(prof.curso)))
                {
                    Console.WriteLine("Medio, " + "Licenciado, " + " Mestre e" + " Dotour");
                    Console.WriteLine(" Escreva um dos niveis");
                }
            }
        }
    }
}