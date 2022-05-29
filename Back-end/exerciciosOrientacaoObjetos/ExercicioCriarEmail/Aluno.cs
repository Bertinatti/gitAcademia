using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCriarEmail
{
    internal class Aluno
    {
        // atributos
        private string nome;
        private string sobrenome;
        private int registroAluno;
        private int registroMatrícula;
        private DateTime dataMatricula;
        private string curso;
        private DateTime dataTermino;

        // método construtor
        public Aluno(string nome, int registroAluno, int registroMatrícula, DateTime dataMatricula, string curso)
        {
            this.nome = nome;
            this.registroAluno = registroAluno;
            this.registroMatrícula = registroMatrícula;
            this.dataMatricula = dataMatricula;
            this.curso = curso;

            // atribuí valor a variável sobrenome utilizando o nome completo que foi digitado
            string sobrenome = "";
            string[] nomeSobrenome = nome.Split(" ");
            for(int i = 1; i < nomeSobrenome.Length; i++)
            {
                sobrenome += Convert.ToString(" " + nomeSobrenome[i]);
            }
            this.sobrenome = sobrenome;

            // atribui valor a data de termino baseado no curso escolhido
            DateTime dataTermino = new DateTime();

            if(curso.Equals("ADMINISTRAÇÃO"))
            {
                dataTermino = dataMatricula.AddYears(4);
            }
            else if (curso.Equals("RECURSOS HUMANOS"))
            {
                dataTermino = dataMatricula.AddYears(2);
            }
            else if (curso.Equals("ANÁLISE E DESENVOLVIMENTO DE SISTEMAS"))
            {
                dataTermino = dataMatricula.AddYears(2);
            }
            else if (curso.Equals("ENGENHARIA CIVIL"))
            {
                dataTermino = dataMatricula.AddYears(5);
            }

            this.dataTermino = dataTermino;

        }

        // método construtor - sobrecarga
        public Aluno(string nome, string sobrenome, int registroAluno, int registroMatrícula, DateTime dataMatricula, string curso, DateTime dataTermino)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.registroAluno = registroAluno;
            this.registroMatrícula = registroMatrícula;
            this.dataMatricula = dataMatricula;
            this.curso = curso;
            this.dataTermino = dataTermino;
        }

        // método de classe para adicionar um semestre no curso do Aluno
        public void adicionaSemestre()
        {
            this.dataTermino = dataTermino.AddMonths(6);
            Console.WriteLine("Adicionado um semestre a data de término do curso, agora a previsão de término é para: {0:dd/MM/yyyy}.", this.DataTermino);
        }

        // método getter e setter
        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; }
        public int RegistroAluno { get => registroAluno; set => registroAluno = value; }
        public int RegistroMatrícula { get => registroMatrícula; set => registroMatrícula = value; }
        public DateTime DataMatricula { get => dataMatricula; set => dataMatricula = value; }
        public string Curso { get => curso; set => curso = value; }
        public DateTime DataTermino { get => dataTermino; }

    }
}
