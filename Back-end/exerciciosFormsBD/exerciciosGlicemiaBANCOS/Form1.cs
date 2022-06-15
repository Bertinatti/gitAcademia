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

namespace exerciciosGlicemiaBANCOS
{
    public partial class Form1 : Form
    {
        private string conexaoString = ConfigurationManager.ConnectionStrings["GlicemiaDBString"].ConnectionString;
        private void carregarListView()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(conexaoString);
                conexao.Open();
                string sqlTexto = "SELECT idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente FROM MedidaGlicemia";
                SqlCommand comando = new SqlCommand(sqlTexto, conexao);

                listView_medidasGlicemias.Items.Clear();
                SqlDataReader leitor = comando.ExecuteReader();
                int i = 0;
                while (leitor.Read())
                {
                    listView_medidasGlicemias.Items.Add(leitor["idMedidaGlicemia"].ToString());
                    listView_medidasGlicemias.Items[i].SubItems.Add(leitor["valorGlicemia"].ToString());
                    listView_medidasGlicemias.Items[i].SubItems.Add(leitor["dataMedida"].ToString());
                    listView_medidasGlicemias.Items[i].SubItems.Add(leitor["idPaciente"].ToString());
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
        public Form1()
        {
            InitializeComponent();
            SqlConnection conexao = new SqlConnection(conexaoString);
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            carregarListView();
            btnConectar.Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //capturar valores das variáveis
                int idMedidaGlicemia = int.Parse(tbIdMedicao.Text);
                int valorGlicemia = int.Parse(tbValorGlicemia.Text);
                string dataMedida = tbDataMedicao.Text;
                int idPaciente = int.Parse(tbIdPaciente.Text);

                //gerar sentenças SQL
                string sqlTexto = "INSERT INTO MedidaGlicemia (idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente) VALUES(@idMedidaGlicemia, @valorGlicemia, @dataMedida, @idPaciente)";
                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);
                comando.Parameters.AddWithValue("@valorGlicemia", valorGlicemia);
                comando.Parameters.AddWithValue("@dataMedida", dataMedida);
                comando.Parameters.AddWithValue("@idPaciente", idPaciente);

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

        private void btnRemover_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //MessageBox.Show(listView_medidasGlicemias.SelectedItems[0].Text);
                int idMedidaGlicemia = int.Parse(listView_medidasGlicemias.SelectedItems[0].Text);

                //gerar sentenças SQL
                string sqlTexto = "DELETE FROM MedidaGlicemia WHERE idMedidaGlicemia = @idMedidaGlicemia";

                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);

                //executar sentença SQL
                if(comando.ExecuteNonQuery() != 0)
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
        }
    }
}
