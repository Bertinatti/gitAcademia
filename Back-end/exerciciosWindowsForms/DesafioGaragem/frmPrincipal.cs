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
        private void popularDataGridEntrada(List<Veiculo> lista)
        {
            dgEntradaVeiculos.Rows.Clear();
            foreach  (Veiculo v in lista)
            {
                dgEntradaVeiculos.Rows.Add(v.PlacaVeiculo, v.DataEntrada, v.HoraEntrada);
            }
        }
        private void popularDataGridSaida(List<Veiculo> lista)
        {
            dgSaidaVeiculos.Rows.Clear();
            foreach (Veiculo v in lista)
            {
                dgSaidaVeiculos.Rows.Add(v.PlacaVeiculo, v.TempoPermanencia, v.ValorCobrado);
            }
        }
        public frmPrincipal()
        {
            InitializeComponent();
            lblDia.Text = DateTime.Now.GetDateTimeFormats().First().ToString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            if(tbPlacaVeiculo.Text.Equals("") || mtbHora.Text.Equals(""))
            {
                MessageBox.Show("Campos vazios.", "Erro!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                listaVeiculosEntrada.Add(new Veiculo(tbPlacaVeiculo.Text, DateTime.Now.Date, Convert.ToDateTime(mtbHora.Text)));

                dgEntradaVeiculos.Rows.Add(tbPlacaVeiculo.Text, DateTime.Now.Date.ToString("dd/MM/yyyy"), mtbHora.Text);
            }
        }

        private void timerHoras_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDia.Text = DateTime.Now.GetDateTimeFormats().First().ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbPlacaVeiculo.Text = "";
            mtbHora.Text = "";
        }

        List<Veiculo> listaVeiculosEntrada = new List<Veiculo>();
        List<Veiculo> listaVeiculosSaida = new List<Veiculo>();

    }
}
