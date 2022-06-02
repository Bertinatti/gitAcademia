using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroWindowsForms
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O nome é: " + txtBoxNome.Text + "\n" +
                "O sexo é: " + txtBoxSexo.Text + "\n" +
                "O e-mail é: " + txtBoxEmail.Text + "\n" +
                "O telefone é: " + txtBoxTelefone.Text + "\n" +
                "O endereço é: " + txtBoxEndereco.Text + "\n" +
                "O bairro é: " + txtBoxBairro.Text + "\n" +
                "A cidade é: " + txtBoxCidade.Text, "Dados cadastrados!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atenção, você estará fechando a aplicação", "Saindo do programa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            Close();
        }
    }
}
