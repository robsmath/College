using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAED04
{
    class Aluno
    {
        private int matricula;
        private String nome, resultado;
        private double nota1, nota2, nota3;

       
        public Aluno (int matricula, string nome, double nota1, double nota2, double nota3)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }
        
        public Aluno()
        {

        }

        public int GetMatricula()
        {
            return matricula;
        }
        public void SetMatricula(int matricula)
        {
            this.matricula = matricula;
        }

        public String GetNome()
        {
            return nome;
        }

        public void SetNome(String nome)
        {
            this.nome = nome;
        }

        public double GetNota1()
        {
            return nota1;
        }

        public void SetNota1(double nota1)
        {
            this.nota1 = nota1;
        }
        public double GetNota2()
        {
            return nota2;
        }

        public void SetNota2(double nota2)
        {
            this.nota2 = nota2;
        }
        public double GetNota3()
        {
            return nota3;
        }

        public void SetNota3 (double nota3)
        {
            this.nota3 = nota3;
        }

        public double GetNotaFinal()
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        public String GetResultado()
        {   
            if(GetNotaFinal() >= 60)
            {
                resultado = "APROVADO";
            } else if(GetNotaFinal() >= 40 && GetNotaFinal() < 60)
            {
                resultado = "RECUPERAÇÃO";
            }
            else
            {
                resultado = "REPROVADO";
            }
            return resultado;
        }
    }
}
