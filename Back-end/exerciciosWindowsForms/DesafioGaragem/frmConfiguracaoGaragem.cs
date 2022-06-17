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
    public partial class frmConfiguracaoGaragem : Form
    {
        /// <summary>
        /// Método para popular as Label que mostram o preço cobrado e o número de vagas.
        /// </summary>
        /// <param name="lista">Lista que guarda os valores de configuração da garagem.</param>
        private void popularLabel(List<Garagem> lista)
        {
            Persistencia.lerArquivoConfiguracaoGaragem(lista);
            foreach (Garagem g in lista)
            {
                lblNumeroVagas.Text = Convert.ToString(g.Vagas);
                lblValorAtual.Text = g.PrecoCobrado.ToString("F");
            }
        }
        public frmConfiguracaoGaragem()
        {
            InitializeComponent();
            Persistencia.lerArquivoConfiguracaoGaragem(listaGaragem);
            popularLabel(listaGaragem);
        }
        /// <summary>
        /// Método para limpar os campos do Forms.
        /// </summary>
        private void limpaCampos()
        {
            tbNovoPreco.Text = "";
            tbVagasGaragem.Text = "";
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.ShowDialog();
        }
        private void frmConfiguracaoGaragem_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if(tbNovoPreco.Text == "" || tbVagasGaragem.Text == "")
            {
                MessageBox.Show("Digite os campos corretamente.", "Erro - CAMPOS EM BRANCO.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Persistencia.gravarArquivoConfiguracaoGaragem(new Garagem(int.Parse(tbVagasGaragem.Text), double.Parse(tbNovoPreco.Text)));
                MessageBox.Show("Dados cadastrados com sucesso.", "Cadastro de configuração - GARAGEM.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                popularLabel(listaGaragem);
                limpaCampos();
            }
        }

        List<Garagem> listaGaragem = new List<Garagem>();

    }
}
