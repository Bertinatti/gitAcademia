using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio001
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void sairMenuItemArquivo_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == MessageBox.Show("Deseja realmente sair?", "Saindo...", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1))
            {
                Application.Exit();
            } 
        }

        private void cadastrarMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void automóvelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario frmCadastroUsuario = new frmCadastroUsuario();
            frmCadastroUsuario.ShowDialog();
        }
    }
}
