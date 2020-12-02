using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Pofessor
{
    class GestaoDoProfessor
    {
        public static void Main(string[] args)
        {
            ArrayList Menu = MetodosDoProfessor.addProfessor();
            int resp = 0;
            do
            {
                Console.WriteLine("------MENU DO PROFESSOR------" +
                                  " 1.IMPRIMIR PROFESSOR " +
                                  " 2.PESQUISAR POR NIVEL " +
                                  " 3.ATUALIZAR NIVEL " +
                                  " 4.SAIR ");

                resp = int.Parse(Console.ReadLine());
                switch (resp)
                {
                    case 1: MetodosDoProfessor.imprimirPofessor(Menu); break;
                    case 2: MetodosDoProfessor.pesquisarPorNivel(Menu); break;
                    case 3: MetodosDoProfessor.atualizarNivel(Menu); break;
                    case 4: Environment.Exit(0); break;
                    default:
                        Console.WriteLine("Escolha  [ 1/2/3/4/5 ] "); break;
                }
            } while (resp != 0);
            Console.Read();
        }
    }
}
