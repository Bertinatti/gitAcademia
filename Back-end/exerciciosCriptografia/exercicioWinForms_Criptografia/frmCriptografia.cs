using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicioWinForms_Criptografia
{
    public partial class frmCriptografia : Form
    {
        Assimetrica a;
        Simetrica s;
        public frmCriptografia()
        {
            InitializeComponent();
            a = new Assimetrica();
            s = new Simetrica();
        }
        private void btnCriptografiaAssimetrica_Click(object sender, EventArgs e)
        {
            try
            {
                string frase, fraseCriptografada;
                frase = tbFrase.Text;
                fraseCriptografada = a.encrypt(frase);
                lblExibirFrase.Text = fraseCriptografada;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro de exceção.");
            }
            
        }
        private void btnDescriptografarAssimetrica_Click(object sender, EventArgs e)
        {
            try
            {
                string frase, fraseDescriptografa;
                frase = lblExibirFrase.Text;
                fraseDescriptografa = a.decrypt(frase);
                lblExibirDescriptografada.Text = fraseDescriptografa;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro de exceção.");
            }
            
        }

        private void btnCriptografiaSimetrica_Click(object sender, EventArgs e)
        {
            try
            {
                string frase, fraseCriptografada, chaveCriptografia;
                frase = tbFrase.Text;
                chaveCriptografia = tbChave.Text;
                fraseCriptografada = s.EncryptData(frase, chaveCriptografia);
                lblExibirFrase.Text = fraseCriptografada;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro de exceção.");
            }
            
        }

        private void btnDescriptografiaSimetrica_Click(object sender, EventArgs e)
        {
            try
            {
                string frase, fraseDescriptografa, chaveDescriptografia;
                frase = lblExibirFrase.Text;
                chaveDescriptografia = tbChave.Text;
                fraseDescriptografa = s.DecryptData(frase, chaveDescriptografia);
                lblExibirDescriptografada.Text = fraseDescriptografa;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro de exceção.");
            }
            
        }
    }
}
