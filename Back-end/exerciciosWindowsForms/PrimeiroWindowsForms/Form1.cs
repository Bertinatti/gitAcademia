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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Cliquei no botão de entrada.");
            //MessageBox.Show("O nome digitado pelo usuário é: " + txtBoxLogin.Text.ToUpper());
            while (true)
            {
                if (txtBoxLogin.Text == "BERTINATTI" && txtBoxPassword.Text == "BERTINATTI")
                {
                    MessageBox.Show("Login efetuado com suceso.\n" +
                                    "Bem-vindo: " + txtBoxLogin.Text, "Login válido!" , MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    frmCadastro frmCadastro = new frmCadastro();
                    frmCadastro.Show();
                    Hide();
                    break;
                }
                else
                {
                    MessageBox.Show("Login inválido.");
                    txtBoxLogin.Text = "";
                    txtBoxPassword.Text = "";
                    break;
                }
            }           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no botão de sair.");
            Close();
        }
    }
}
