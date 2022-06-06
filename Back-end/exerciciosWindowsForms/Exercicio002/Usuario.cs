using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio002
{
    internal class Usuario
    {
        private string nome;
        private string telefone;
        private string cpf;
        private string login;
        private string senha;
        private bool status;
        private int tipo;

        public Usuario(string nome, string telefone, string cpf, string login, string senha, bool status, int tipo)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.cpf = cpf;
            this.login = login;
            this.senha = senha;
            this.status = status;
            this.tipo = tipo;
        }

        public void DesativarUsuario()
        {
            this.status = false;
        }

        public void MostrarDados()
        {
            string mostrarStatus;
            string tipoUsuario;
            if (this.status == true)
            {
                mostrarStatus = "Ativo";
            }
            else
            {
                mostrarStatus = "Inativo";
            }

            if (this.tipo == 0)
            {
                tipoUsuario = "Usuário padrão";
            }
            else
            {
                tipoUsuario = "Administrador";
            }

            MessageBox.Show($"Nome do usuário: {this.nome} \n" +
                            $"Telefone: {this.telefone}\n" +
                            $"CPF: {this.cpf}\n" +
                            $"Login: {this.login}\n" +
                            $"Senha: {this.senha}\n" +
                            $"Nível do usuário: {tipoUsuario}\n" +
                            $"Status: { mostrarStatus}");
        }

        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public bool Status { get => status; set => status = value; }
        public int Tipo { get => tipo; set => tipo = value; }
    }
}
