using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace exercicioWinForms_Serializacao
{
    [Serializable]
    public class Paciente
    {
        private string nome;
        private DateTime dataNascimento;
        private string cpf;

        public Paciente()
        {
        }

        public Paciente(string nome, DateTime dataNascimento, string cpf)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Cpf = cpf;
        }

        public string Nome { get => nome; set => nome = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string Cpf { get => cpf; set => cpf = value; }
    }
}
