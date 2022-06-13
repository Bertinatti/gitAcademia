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
        public frmConfiguracaoGaragem()
        {
            InitializeComponent();
        }
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
    }
}
