using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio002
{
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbNome.Clear();
            tbLogin.Clear();
            tbSenha.Clear();
            cbTipoUsuario.ResetText();
            mtbCPF.Clear();
            mtbTelefone.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool status = true;
            int  tipo = 0;
            string nome, login, senha, telefone, cpf;

            nome = tbNome.Text.ToUpper();
            login = tbLogin.Text;
            senha = tbSenha.Text;
            telefone = mtbCPF.Text;
            cpf = mtbTelefone.Text;

            if (cbTipoUsuario.Text == "Administrador")
            {
                tipo = 1;
            }

            Usuario usuario = new Usuario(nome, telefone, cpf, login, senha, status, tipo);

            usuario.MostrarDados();

        }
    }
}
