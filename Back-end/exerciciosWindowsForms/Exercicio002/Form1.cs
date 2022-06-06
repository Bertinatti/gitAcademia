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
            btnMostrarEsconder.BackgroundImage = imageListMostrarEsconder.Images[0];
        }

        bool trocaImagem = false;

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
            telefone = mtbTelefone.Text;
            cpf = mtbCPF.Text;

            if (cbTipoUsuario.Text == "Administrador")
            {
                tipo = 1;
            }

            Usuario usuario = new Usuario(nome, telefone, cpf, login, senha, status, tipo);

            usuario.MostrarDados();

        }

        private void btnMostrarEsconder_Click(object sender, EventArgs e)
        {
            if (trocaImagem == false)
            {
                btnMostrarEsconder.BackgroundImage = imageListMostrarEsconder.Images[1];
                trocaImagem = true;
                tbSenha.UseSystemPasswordChar = false;
            }
            else
            {
                btnMostrarEsconder.BackgroundImage = imageListMostrarEsconder.Images[0];
                trocaImagem = false;
                tbSenha.UseSystemPasswordChar = true;
            }
        }
    }
}
