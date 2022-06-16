using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exerciciosFormsSimplesComBanco
{
    public partial class frmCadastroPessoa : Form
    {
        /// <summary>
        /// Método para limpar os campos dos TextBox.
        /// </summary>
        private void limpaCampos()
        {
            tbNome.Text = "";
            tbIdade.Text = "";
            tbCPF.Text = "";
            tbEndereco.Text = "";
            tbBairro.Text = "";
            tbCEP.Text = "";
            tbCidade.Text = "";
            tbNome.Focus();
        }
        public frmCadastroPessoa()
        {
            InitializeComponent();
            tbNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //string nome, int idade, string cpf, string endereco, string bairro, string cep, string cidade
            Pessoa p = new Pessoa(tbNome.Text, int.Parse(tbIdade.Text), tbCPF.Text, tbEndereco.Text, tbBairro.Text, tbCEP.Text, tbCidade.Text);
            p.gravarPessoa();
            MessageBox.Show("Nome do indivíduo: " + p.Nome + "\nCPF do indivíduo: " + p.Cpf);
            limpaCampos();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }
    }
}
