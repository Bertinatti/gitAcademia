using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace exercicioWindowsForm_BD
{
    public partial class frmCadastroUsuario : Form
    {   
        /*
        private string conexaoString = ConfigurationManager.ConnectionStrings["UsuarioDBString"].ConnectionString;
        
        private void carregarListView()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(conexaoString);
                conexao.Open();
                string sqlTexto = "SELECT idUsuario, nomeCompleto, email FROM usuario";
                SqlCommand comando = new SqlCommand(sqlTexto, conexao);

                lvBanco.Items.Clear();
                SqlDataReader leitor = comando.ExecuteReader();
                int i = 0;
                while (leitor.Read())
                {
                    lvBanco.Items.Add(leitor["idUsuario"].ToString());
                    lvBanco.Items[i].SubItems.Add(leitor["nomeCompleto"].ToString());
                    lvBanco.Items[i].SubItems.Add(leitor["email"].ToString());                 
                    i++;
                }

                leitor.Close();

                conexao.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro atingido" + ex.Message, "Erro na conexão!");
            }
        }
        */
        private void carregarListView()
        {
            lvBanco.Items.Clear();
            Banco banco = new Banco();
            string sql = "select * from usuario";
            DataTable dt = banco.executarConsultaGenerica(sql);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                lvBanco.Items.Add(item);
            }
        }
        public void limpaCampos()
        {
            tbIdUsuario.Text = "";
            tbNomeCompleto.Text = "";
            tbIdUsuario.Focus();
        }
        public frmCadastroUsuario()
        {
            InitializeComponent();
            /* SqlConnection conexao = new SqlConnection(conexaoString); */
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            carregarListView();
            btnConectar.Enabled = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(int.Parse(tbIdUsuario.Text), tbNomeCompleto.Text);
            usuario.gravarUsuario();
            carregarListView();
            limpaCampos();
            /*
            if(tbIdUsuario.Text == "" || tbNomeCompleto.Text == "")
            {
                MessageBox.Show("Os campos estão vazios.", "Erro - CAMPOS VAZIOS.", MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection conexao = new SqlConnection(conexaoString);
                conexao.Open();
                try
                {
                    //capturar valores das variáveis
                    Usuario usuario = new Usuario(int.Parse(tbIdUsuario.Text), tbNomeCompleto.Text);

                    //gerar sentenças SQL
                    string sqlTexto = "INSERT INTO usuario (idUsuario, nomeCompleto, email) VALUES(@idUsuario, @nomeCompleto, @email)";
                    SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                    comando.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario);
                    comando.Parameters.AddWithValue("@nomeCompleto", usuario.NomeCompleto);
                    comando.Parameters.AddWithValue("@email", usuario.Email);

                    //executar sentença SQL
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro atingido" + ex.Message, "Erro na conexão!");
                }

                conexao.Close();

                //recarregar ListView
                carregarListView();
            }
            */
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int idUsuario = int.Parse(lvBanco.SelectedItems[0].Text);
            bool retornaQuery = Usuario.deletarUsuario(idUsuario);
            if (retornaQuery)
            {
                MessageBox.Show("Remoção de usuário efetuado com sucesso.", "Sucesso na remoção.", MessageBoxButtons.OK);
                //carregarListView();
                int indice = (lvBanco.SelectedItems[0].Index);
                lvBanco.Items.RemoveAt(indice);
            }
            else
            {
                MessageBox.Show("Remoção de usuário não foi fetuado com sucesso.", "Falha na remoção.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpaCampos();
            /*
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //MessageBox.Show(listView_medidasGlicemias.SelectedItems[0].Text);
                int idUsuario = int.Parse(lvBanco.SelectedItems[0].Text);

                //gerar sentenças SQL
                string sqlTexto = "DELETE FROM usuario WHERE idUsuario = @idUsuario";

                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idUsuario", idUsuario);

                //executar sentença SQL
                if (comando.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Remoção realizada com sucesso.", "Removido com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro atingido" + ex.Message, "Erro na conexão!");
            }

            conexao.Close();

            //recarregar ListView
            carregarListView();
            */
        }
    }
}
