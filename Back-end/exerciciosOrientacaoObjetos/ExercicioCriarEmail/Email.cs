using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCriarEmail
{
    internal class Email
    {
        private string emailUsuario;
        private string nome;
        private string curso;
        private int registroMatricula;

        public Email(string nome, string curso, int registroMatricula)
        {
            this.nome = nome;
            this.curso = curso;
            this.registroMatricula = registroMatricula;

            // atribuí valor a variável sobrenome utilizando o nome completo que foi digitado
            string sobrenome = "";
            string[] nomeSobrenome = nome.Split(" ");
            for (int i = 1; i < nomeSobrenome.Length; i++)

            // atribuí valor para o e-mail
            this.emailUsuario = nomeSobrenome[nomeSobrenome.Length - 1] + "." + nomeSobrenome[0] + "@ufn.edu.br";
            this.emailUsuario = this.emailUsuario.ToLower();
        }

        public Email(string emailUsuario, string nome, string curso, int registroMatricula)
        {
            this.emailUsuario = emailUsuario;
            this.nome = nome;
            this.curso = curso;
            this.registroMatricula = registroMatricula;
        }

        public string EmailUsuario { get => emailUsuario; }
        public string Nome { get => nome; set => nome = value; }
        public string Curso { get => curso; set => curso = value; }
        public int RegistroMatricula { get => registroMatricula; set => registroMatricula = value; }
        
    }
}
