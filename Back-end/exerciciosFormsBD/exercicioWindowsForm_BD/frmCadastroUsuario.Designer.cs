namespace exercicioWindowsForm_BD
{
    partial class frmCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroUsuario));
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lvBanco = new System.Windows.Forms.ListView();
            this.chIdUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNomeCompleto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCadastroUsuario = new System.Windows.Forms.Label();
            this.tbIdUsuario = new System.Windows.Forms.TextBox();
            this.tbNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(12, 410);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(145, 28);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(163, 410);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(145, 28);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(314, 410);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(145, 28);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lvBanco
            // 
            this.lvBanco.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chIdUsuario,
            this.chNomeCompleto,
            this.chEmail});
            this.lvBanco.FullRowSelect = true;
            this.lvBanco.HideSelection = false;
            this.lvBanco.Location = new System.Drawing.Point(13, 126);
            this.lvBanco.Name = "lvBanco";
            this.lvBanco.Size = new System.Drawing.Size(446, 269);
            this.lvBanco.TabIndex = 3;
            this.lvBanco.UseCompatibleStateImageBehavior = false;
            this.lvBanco.View = System.Windows.Forms.View.Details;
            this.lvBanco.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvBanco_ColumnClick);
            // 
            // chIdUsuario
            // 
            this.chIdUsuario.Text = "Id usuário:";
            this.chIdUsuario.Width = 80;
            // 
            // chNomeCompleto
            // 
            this.chNomeCompleto.Text = "Nome completo:";
            this.chNomeCompleto.Width = 145;
            // 
            // chEmail
            // 
            this.chEmail.Text = "E-mail:";
            this.chEmail.Width = 215;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblCadastroUsuario);
            this.panel1.Location = new System.Drawing.Point(13, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 32);
            this.panel1.TabIndex = 4;
            // 
            // lblCadastroUsuario
            // 
            this.lblCadastroUsuario.AutoSize = true;
            this.lblCadastroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroUsuario.Location = new System.Drawing.Point(78, 7);
            this.lblCadastroUsuario.Name = "lblCadastroUsuario";
            this.lblCadastroUsuario.Size = new System.Drawing.Size(288, 16);
            this.lblCadastroUsuario.TabIndex = 0;
            this.lblCadastroUsuario.Text = "CADASTRO - Cadastrando usuário no sistema.";
            // 
            // tbIdUsuario
            // 
            this.tbIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdUsuario.Location = new System.Drawing.Point(13, 84);
            this.tbIdUsuario.Name = "tbIdUsuario";
            this.tbIdUsuario.Size = new System.Drawing.Size(100, 22);
            this.tbIdUsuario.TabIndex = 5;
            // 
            // tbNomeCompleto
            // 
            this.tbNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeCompleto.Location = new System.Drawing.Point(120, 83);
            this.tbNomeCompleto.Name = "tbNomeCompleto";
            this.tbNomeCompleto.Size = new System.Drawing.Size(339, 22);
            this.tbNomeCompleto.TabIndex = 6;
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUsuario.Location = new System.Drawing.Point(12, 64);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(68, 16);
            this.lblIdUsuario.TabIndex = 7;
            this.lblIdUsuario.Text = "Id usuário:";
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCompleto.Location = new System.Drawing.Point(117, 64);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(106, 16);
            this.lblNomeCompleto.TabIndex = 8;
            this.lblNomeCompleto.Text = "Nome completo:";
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.lblIdUsuario);
            this.Controls.Add(this.tbNomeCompleto);
            this.Controls.Add(this.tbIdUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvBanco);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnConectar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USUÁRIO -  Cadastro usuário.";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ListView lvBanco;
        private System.Windows.Forms.ColumnHeader chIdUsuario;
        private System.Windows.Forms.ColumnHeader chNomeCompleto;
        private System.Windows.Forms.ColumnHeader chEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCadastroUsuario;
        private System.Windows.Forms.TextBox tbIdUsuario;
        private System.Windows.Forms.TextBox tbNomeCompleto;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.Label lblNomeCompleto;
    }
}

