using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace exercicioWindowsForm_BD
{
    internal class Usuario
    {
        private int idUsuario;
        private string nomeCompleto;
        private string email;

        public Usuario(int idUsuario, string nomeCompleto)
        {
            this.idUsuario = idUsuario;
            this.nomeCompleto = nomeCompleto;
            gerarEmail(nomeCompleto);
        }
        private void gerarEmail(string nomeCompleto)
        {
            string[] emailSplit = nomeCompleto.ToLower().Split(' ');
            string email = emailSplit[0] + "." + emailSplit[emailSplit.Length - 1] + "@ufn.edu.br";
            this.email = email;
        }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NomeCompleto { get => nomeCompleto; set => nomeCompleto = value; }
        public string Email { get => email; set => email = value; }
        //public bool gravarUsuario()
        //{
        //    Banco banco = new Banco();
        //    SqlConnection cn = banco.abrirConexao();
        //    SqlTransaction tran = cn.BeginTransaction();
        //    SqlCommand command = new SqlCommand();
        //    command.Connection = cn;
        //    command.Transaction = tran;
        //    command.CommandType = CommandType.Text;
        //    command.CommandText = "insert into usuario values (@idUsuario, @nomeCompleto, @email);";
        //    command.Parameters.Add("@nomeCompleto", SqlDbType.Int);
        //    command.Parameters.Add("@nomeCompleto", SqlDbType.VarChar);
        //    command.Parameters.Add("@email", SqlDbType.VarChar);
        //    command.Parameters[0].Value = this.idUsuario;
        //    command.Parameters[1].Value = this.nomeCompleto;
        //    command.Parameters[2].Value = this.email;
        //    try
        //    {
        //        command.ExecuteNonQuery();
        //        tran.Commit();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        tran.Rollback();
        //        return false;
        //    }
        //    finally
        //    {
        //        banco.fecharConexao();
        //    }
        //}
    }
}

