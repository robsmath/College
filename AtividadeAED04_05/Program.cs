using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAED04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numAlunos;

            TestaAluno teste = new TestaAluno();

            Console.WriteLine("Digite quantos alunos deseja cadastrar: ");
            numAlunos = Convert.ToInt32(Console.ReadLine());
            
            teste.CadastraAlunos(numAlunos);
        }
    }
}
