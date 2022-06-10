namespace Exercicio_UpdateArquivo
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblNome = new System.Windows.Forms.Label();
            this.tbNomePessoa = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.tbListaUsuario = new System.Windows.Forms.TextBox();
            this.lblCadastrado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(90, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome de pessoa:";
            // 
            // tbNomePessoa
            // 
            this.tbNomePessoa.Location = new System.Drawing.Point(109, 10);
            this.tbNomePessoa.Name = "tbNomePessoa";
            this.tbNomePessoa.Size = new System.Drawing.Size(294, 20);
            this.tbNomePessoa.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(16, 287);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(189, 23);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(214, 287);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(189, 23);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // tbListaUsuario
            // 
            this.tbListaUsuario.Enabled = false;
            this.tbListaUsuario.Location = new System.Drawing.Point(16, 70);
            this.tbListaUsuario.Multiline = true;
            this.tbListaUsuario.Name = "tbListaUsuario";
            this.tbListaUsuario.Size = new System.Drawing.Size(387, 201);
            this.tbListaUsuario.TabIndex = 4;
            // 
            // lblCadastrado
            // 
            this.lblCadastrado.AutoSize = true;
            this.lblCadastrado.Location = new System.Drawing.Point(13, 50);
            this.lblCadastrado.Name = "lblCadastrado";
            this.lblCadastrado.Size = new System.Drawing.Size(150, 13);
            this.lblCadastrado.TabIndex = 5;
            this.lblCadastrado.Text = "Lista de pessoas cadastradas:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 330);
            this.Controls.Add(this.lblCadastrado);
            this.Controls.Add(this.tbListaUsuario);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.tbNomePessoa);
            this.Controls.Add(this.lblNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Formulário Cadastro e Remoção de Usuários";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbNomePessoa;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox tbListaUsuario;
        private System.Windows.Forms.Label lblCadastrado;
    }
}

