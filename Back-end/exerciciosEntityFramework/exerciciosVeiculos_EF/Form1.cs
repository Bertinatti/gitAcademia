using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exerciciosVeiculos_EF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            popularDataGridModelos();

            popularDataGridVeiculos();
      
        }
        public void popularDataGridModelos()
        {
            dgModelos.Rows.Clear();
            foreach (var i in Modelo.Todos())
            {
                dgModelos.Rows.Add(i.Id, i.Nome);
            }
        }
        public void popularDataGridVeiculos()
        {
            dgVeiculos.Rows.Clear();
            foreach (var i in Veiculo.Todos())
            {
                dgVeiculos.Rows.Add(i.Id, i.ModeloId, i.Nome, i.Ano);
            }
        }
        private void btnGravarModelo_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeModelo = tbModelos.Text;

                Modelo novoModelo = new Modelo() { Nome = nomeModelo };

                novoModelo.Salvar();

                MessageBox.Show("Sucesso na inserção de dados.", "Sucesso");

                tbModelos.Text = "";

                popularDataGridModelos();
            }
            catch (Exception)
            {

                throw;
            }          
        }

        private void btnGravarVeiculo_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeVeiculo = tbNome.Text;
                int anoVeiculo = int.Parse(tbAno.Text);
                int modeloVeiculo = int.Parse(tbModeloVeiculo.Text);

                Veiculo novoVeiculo = new Veiculo() { Nome = nomeVeiculo, ModeloId = modeloVeiculo, Ano = anoVeiculo };

                MessageBox.Show("Sucesso na inserção de dados.", "Sucesso");

                tbNome.Text = "";
                tbAno.Text = "";
                tbModeloVeiculo.Text = "";

                popularDataGridVeiculos();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
