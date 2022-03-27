using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAED04
{
    class TestaAluno
    {

        public void CadastraAlunos(int numAlunos)
        {
            Aluno[] alunos = new Aluno[numAlunos];

            

            for (int i = 0; i < numAlunos; i++)
            {
                Aluno aluno01 = new Aluno();

                Console.WriteLine("Digite a matrícula do " + (i + 1) + "º aluno: ");
                aluno01.SetMatricula(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Digite o nome do " + (i + 1) + "º aluno: ");
                aluno01.SetNome(Console.ReadLine());

                Console.WriteLine("Entre com a primeira nota do aluno: ");
                aluno01.SetNota1(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("Entre com a segunda nota do aluno: ");
                aluno01.SetNota2(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("Entre com a terceira nota do aluno: ");
                aluno01.SetNota3(Convert.ToDouble(Console.ReadLine()));

                alunos[i] = aluno01;

                Console.Clear();
            }
            Console.WriteLine("RESULTADO FINAL: ");
            Console.WriteLine("--------------------");
            for (int i = 0; i < numAlunos; i++)
            {

                Console.WriteLine("Nome: " + alunos[i].GetNome());

                Console.WriteLine("Situação: " + alunos[i].GetResultado());

                Console.WriteLine("********************");

            }
        }
    }
}
