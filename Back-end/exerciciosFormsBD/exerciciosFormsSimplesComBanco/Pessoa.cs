using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace exerciciosFormsSimplesComBanco
{
    internal class Pessoa
    {
        private string nome;
        private int idade;
        private string cpf;
        private string endereco;
        private string bairro;
        private string cep;
        private string cidade;
        /// <summary>
        /// Método construtor para um objeto da classe PESSOA.
        /// </summary>
        /// <param name="nome">Parâmetro do tipo string com o NOME da pessoa.</param>
        /// <param name="idade">Parâmetro do tipo int com a IDADE da pessoa.</param>
        /// <param name="cpf">Parâmetro do tipo string com o CPF da pessoa.</param>
        /// <param name="endereco">Parâmetro do tipo string com o ENDEREÇO da pessoa.</param>
        /// <param name="bairro">Parâmetro do tipo string com o BAIRRO da pessoa.</param>
        /// <param name="cep">Parâmetro do tipo string com o CEP da pessoa.</param>
        /// <param name="cidade">Parâmetro do tipo string com a CIDADE da pessoa.</param>
        public Pessoa(string nome, int idade, string cpf, string endereco, string bairro, string cep, string cidade)
        {
            this.nome = nome;
            this.idade = idade;
            this.cpf = cpf;
            this.endereco = endereco;
            this.bairro = bairro;
            this.cep = cep;
            this.cidade = cidade;
        }
        /// <summary>
        /// Método público para gravar os dados da pessoa no banco de dados.
        /// </summary>
        /// <returns>Retorna true para caso tenha efetuado a gravação no banco de dados.</returns>
        public bool gravarPessoa()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into pessoa values (@nome, @idade, @cpf, @ende, @bairro, @cep, @cidade);";
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@idade", SqlDbType.Int);
            command.Parameters.Add("@cpf", SqlDbType.VarChar);
            command.Parameters.Add("@ende", SqlDbType.VarChar);
            command.Parameters.Add("@bairro", SqlDbType.VarChar);
            command.Parameters.Add("@cep", SqlDbType.VarChar);
            command.Parameters.Add("@cidade", SqlDbType.VarChar);
            command.Parameters[0].Value = this.nome;
            command.Parameters[1].Value = this.idade;
            command.Parameters[2].Value = this.cpf;
            command.Parameters[3].Value = this.endereco;
            command.Parameters[4].Value = this.bairro;
            command.Parameters[5].Value = this.cep;
            command.Parameters[6].Value = this.cidade;
            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }
        }
        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Cidade { get => cidade; set => cidade = value; }
    }
}
