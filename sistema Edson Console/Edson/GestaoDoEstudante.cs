using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Edson
{
    class GestaoDoEstudante
    {
        public static void Main(string[] args)
        {

            ArrayList lista = MetodosDoEstudante.addEstudante();
            int resp = 0;

            do
            {
                System.Console.WriteLine("---------Menu--------"+
                                         "1: lista Agrupada De Estudantes "+
                                         "2: pelomenos Uma Nota Negativa "+
                                         "3: actualizar Estudantes Com Negativas "+
                                         "4: sair ");

                resp = int.Parse(System.Console.ReadLine());
                switch (resp)
                {

                    case 1: MetodosDoEstudante.listaAgrupadaDeEstudante(lista); break;
                    case 2: MetodosDoEstudante.pelomenosUmaNotaNegativa(lista); break;
                    case 3: MetodosDoEstudante.actualizarEstudanteComNegativas(lista); break;
                    case 4: Environment.Exit(0); break;
                    default: Console.WriteLine(" Escolha [1/2/3/4/5] "); break;
                }

            } while (resp != null);
            System.Console.Read();
        }
    }
}
