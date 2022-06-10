using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_UpdateArquivo
{
    public partial class frmPrincipal : Form
    {
        /// <summary>
        /// Popula os dados da lista no TextBox com Multiplas linhas.
        /// </summary>
        /// <param name="lista"></param>
        private void popularTextBoxListaPessoas(List<Pessoa> lista)
        {
            // limpa o TextBox de exibição e faz o população dos dados.
            tbListaUsuario.Clear();
            foreach  (Pessoa i in lista)
            {
                tbListaUsuario.AppendText(i.NomeCompleto + " : " + i.Email + Environment.NewLine);
            }
        }
        public frmPrincipal()
        {
            // inicializa o Form, traz os dados do arquivo e popula no TextBox
            InitializeComponent();
            Persistencia.trazerDoArquivo(listaPessoas);
            popularTextBoxListaPessoas(listaPessoas);
        }

        /// <summary>
        /// Botão de cadastro de usuário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // verifica se o TextBox está vazio
            if (tbNomePessoa.Text.Equals(""))
            {
                MessageBox.Show("Digite um valor!", "Alerta");
                return;
            }
            // coloca o texto do TextBox em maiusculo
            tbNomePessoa.Text = tbNomePessoa.Text.ToUpper();
            // verifica se a pessoa já está cadastrada e faz o cadastro se não estiver
            if(Pessoa.jaCadastrado(tbNomePessoa.Text, listaPessoas))
            {
                MessageBox.Show("Essa pessoa já está cadastrada na lista", "Alerta");
            }
            else
            {
                // cria o email baseado na regra: PrimeiroNome.ÚltimoNome@ufn.edu.br
                string[] emailSplit = tbNomePessoa.Text.ToLower().Split(' ');
                string email = emailSplit[0] + "." + emailSplit[emailSplit.Length - 1] + "@ufn.edu.br";
                // adiciona o novo usuário na lista
                listaPessoas.Add(new Pessoa(tbNomePessoa.Text, email));
                // adiciona o usuário na última posição do TextBox de multiplas linhas
                tbListaUsuario.AppendText(tbNomePessoa.Text + " : " + email + Environment.NewLine);
                // persiste os dados no arquivo
                Persistencia.gravarNoArquivo(listaPessoas);
                // limpa o conteúdo do TextBox
                tbNomePessoa.Text = "";
            }
        }

        // lista para adicionar os usuários
        List<Pessoa> listaPessoas = new List<Pessoa>();

        /// <summary>
        /// Botão de remover o usuário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemover_Click(object sender, EventArgs e)
        {
            // coloca o texto do TextBox em maisculo
            tbNomePessoa.Text = tbNomePessoa.Text.ToUpper();

            // recebe a posição da lista vinda do método localiza
            int posicao = Pessoa.localiza(tbNomePessoa.Text, listaPessoas);
            // verifica a posição e faz a exclusão do usuário através da sua posiçao
            if(posicao == -27)
            {
                MessageBox.Show("Pessoa não consta na lista", "Alerta");
            }
            else
            {
                listaPessoas.RemoveAt(posicao);
                popularTextBoxListaPessoas(listaPessoas);
                Persistencia.gravarNoArquivo(listaPessoas);       
            }
        }
    }
}
