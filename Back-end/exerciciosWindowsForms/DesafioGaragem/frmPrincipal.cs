using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioGaragem
{
    public partial class frmPrincipal : Form
    {
        /// <summary>
        /// Método para popular os dados da lista no DataGridView.
        /// </summary>
        /// <param name="lista">Lista com os veículos que estão utilizando o sistema.</param>
        private void popularDataGridEntrada(List<Veiculo> lista)
        {
            dgEntradaVeiculos.Rows.Clear();
            foreach  (Veiculo v in lista)
            {
                dgEntradaVeiculos.Rows.Add(v.PlacaVeiculo, v.DataEntrada, v.HoraEntrada);
            }
        }
        /// <summary>
        /// Método para popular os dados da lista no DataGridView.
        /// </summary>
        /// <param name="lista">Lista com os veículos que já utilizaram o sistema.</param>
        private void popularDataGridSaida(List<Veiculo> lista)
        {
            dgSaidaVeiculos.Rows.Clear();
            foreach (Veiculo v in lista)
            {
                dgSaidaVeiculos.Rows.Add(v.PlacaVeiculo, v.TempoPermanencia, v.ValorCobrado);
            }
        }
        /// <summary>
        /// Método para limpar os campos do sistema.
        /// </summary>
        private void limparCampos()
        {
            tbPlacaVeiculo.Text = "";
            mtbHora.Text = "";
        }
        /// <summary>
        /// Método para verificar os campos de entrada.
        /// </summary>
        /// <param name="veiculoNaGaragem">Parâmetro retorno do método da classe veículo.</param>
        /// <param name="vagasNaGaragem">Parâmetro retorno do método da classe veículo.</param>
        /// <param name="horarioFuncionamento">Parâmetro retorno do método da classe veículo.</param>
        private void verificaCamposEntrada(bool veiculoNaGaragem, bool vagasNaGaragem, bool horarioFuncionamento)
        {
            if (veiculoNaGaragem == true && vagasNaGaragem == false && horarioFuncionamento == false)
            {
                MessageBox.Show("A placa digitada já está estacionada na garagem.\nEstamos sem vagas e fora do horario de funcionamento.", "Erro - SIGA AS INSTRUÇÕES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limparCampos();
            }
            else if (veiculoNaGaragem == true && vagasNaGaragem == false)
            {
                MessageBox.Show("A placa digitada já está estacionada na garagem.\nEstamos sem vagas na garagem.", "Erro - SIGA AS INSTRUÇÕES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limparCampos();
            }
            else if (veiculoNaGaragem == true && horarioFuncionamento == false)
            {
                MessageBox.Show("A placa digitada já está estacionada na garagem.\nEstamos fora do horario de funcionamento.", "Erro - SIGA AS INSTRUÇÕES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limparCampos();
            }
            else if (vagasNaGaragem == false && horarioFuncionamento == false)
            {
                MessageBox.Show("Estamos sem vagas e fora do horario de funcionamento.", "Erro - SIGA AS INSTRUÇÕES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limparCampos();
            }
            else if (veiculoNaGaragem == true)
            {
                MessageBox.Show("A placa digitada já está estacionada na garagem.", "Erro - SIGA AS INSTRUÇÕES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limparCampos();
            }
            else if (vagasNaGaragem == false)
            {
                MessageBox.Show("Estamos sem vagas na garagem.", "Erro - SIGA AS INSTRUÇÕES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limparCampos();
            }
            else if (horarioFuncionamento == false)
            {
                MessageBox.Show("Estamos fora do horario de funcionamento.", "Erro - SIGA AS INSTRUÇÕES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limparCampos();
            }
        }
        public frmPrincipal()
        {
            InitializeComponent();
            lblDia.Text = DateTime.Now.GetDateTimeFormats().First().ToString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            Persistencia.lerArquivoVeiculosEntrada(listaVeiculosEntrada);
            Persistencia.lerArquivoVeiculosSaida(listaVeiculosSaida);
            popularDataGridEntrada(listaVeiculosEntrada);
            popularDataGridSaida(listaVeiculosSaida);

        }
        private void btnEntrada_Click(object sender, EventArgs e)
        {
            bool validarHora = Veiculo.validaHora(mtbHora.Text);
            if (!validarHora)
            {
                MessageBox.Show("Digite uma hora válida, no padrão europeu de 24 horas com o formato - HORAS:MINUTOS.", "Erro - HORA INVÁLIDA.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limparCampos();
            }
            if(tbPlacaVeiculo.Text.Equals("") || mtbHora.Text.Equals(""))
            {
                MessageBox.Show("Digite os campos corretamente.", "Erro - CAMPOS EM BRANCO.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool veiculoNaGaragem = Veiculo.verificaGaragem(tbPlacaVeiculo.Text, listaVeiculosEntrada);
                bool vagasNaGaragem = Veiculo.verificaVagasGaragem(listaVeiculosEntrada);
                bool horarioFuncionamento = Veiculo.verificaHoraFuncionamento(mtbHora.Text);
                if (veiculoNaGaragem == false && vagasNaGaragem == true && horarioFuncionamento == true)
                {
                    listaVeiculosEntrada.Add(new Veiculo(tbPlacaVeiculo.Text, Veiculo.gerarData(), mtbHora.Text));
                    dgEntradaVeiculos.Rows.Add(tbPlacaVeiculo.Text, DateTime.Now.Date.ToString("dd/MM/yyyy"), mtbHora.Text);
                    Persistencia.gravarArquivoVeiculosEntrada(new Veiculo(tbPlacaVeiculo.Text, Veiculo.gerarData(), mtbHora.Text));
                    limparCampos();
                }
                verificaCamposEntrada(veiculoNaGaragem, vagasNaGaragem, horarioFuncionamento);         
            }
            tbPlacaVeiculo.Focus();
        }

        private void timerHoras_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDia.Text = DateTime.Now.GetDateTimeFormats().First().ToString();
            int vagas = 50;
            int contaColuna = int.Parse(dgEntradaVeiculos.RowCount.ToString());
            lblNumeroVagas.Text = Convert.ToString(vagas - contaColuna);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            tbPlacaVeiculo.Focus();
        }

        List<Veiculo> listaVeiculosEntrada = new List<Veiculo>();
        List<Veiculo> listaVeiculosSaida = new List<Veiculo>();

        private void btnSaida_Click(object sender, EventArgs e)
        {
            bool validarHora = Veiculo.validaHora(mtbHora.Text);
            if (!validarHora)
            {
                MessageBox.Show("Digite uma hora válida, no padrão europeu de 24 horas com o formato - HORAS:MINUTOS.", "Erro - HORA INVÁLIDA.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limparCampos();
            }
            else if (tbPlacaVeiculo.Text.Equals("") || mtbHora.Text.Equals(""))
            {
                MessageBox.Show("Digite os campos corretamente.", "Erro - CAMPOS EM BRANCO.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool veiculoNaGaragem = Veiculo.verificaGaragem(tbPlacaVeiculo.Text, listaVeiculosEntrada);
                if (veiculoNaGaragem == true)
                {
                    int posicao = Veiculo.localizaNaLista(tbPlacaVeiculo.Text, listaVeiculosEntrada);
                    Veiculo veiculoTMP = listaVeiculosEntrada[posicao];
                    veiculoTMP.realizarCobranca(mtbHora.Text);
                    listaVeiculosEntrada.RemoveAt(posicao);
                    listaVeiculosSaida.Add(veiculoTMP);
                    popularDataGridEntrada(listaVeiculosEntrada);
                    popularDataGridSaida(listaVeiculosSaida);
                    if(listaVeiculosEntrada.Count == 0)
                    {
                        Persistencia.limparArquivoVeiculosEntrada();
                        dgEntradaVeiculos.Rows.Clear();
                    }
                    else
                    {
                        Persistencia.limparArquivoVeiculosEntrada();
                        dgEntradaVeiculos.Rows.Clear();
                        foreach (Veiculo i in listaVeiculosEntrada)
                        {
                            Persistencia.gravarArquivoVeiculosEntrada(i);
                            dgEntradaVeiculos.Rows.Add(i.PlacaVeiculo, i.DataEntrada, i.HoraEntrada);
                        }
                    }
                    Persistencia.gravarArquivoVeiculosSaida(veiculoTMP);
                    limparCampos();
                }
                else
                {
                    MessageBox.Show("A PLACA digitada não está cadastrada no sistema.", "Erro - PLACA INVÁLIDA.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    limparCampos();
                }

            }
            tbPlacaVeiculo.Focus();
        }
        private void dgEntradaVeiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbPlacaVeiculo.Text = dgEntradaVeiculos.CurrentRow.Cells[0].Value.ToString();
        }
        private void dgSaidaVeiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbPlacaVeiculo.Text = dgSaidaVeiculos.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            frmConfiguracaoGaragem frmConfig = new frmConfiguracaoGaragem();
            frmConfig.ShowDialog();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}