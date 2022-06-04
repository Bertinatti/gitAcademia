namespace Exercicio001
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtBoxModelo = new System.Windows.Forms.TextBox();
            this.txtBoxFabricante = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.lblOpcionais = new System.Windows.Forms.Label();
            this.tabControlCadastro = new System.Windows.Forms.TabControl();
            this.tabPagCadastroCarro = new System.Windows.Forms.TabPage();
            this.lblPortas = new System.Windows.Forms.Label();
            this.comboBoxPortas = new System.Windows.Forms.ComboBox();
            this.checkListBoxOpcionais = new System.Windows.Forms.CheckedListBox();
            this.tabPageCadastroUsuário = new System.Windows.Forms.TabPage();
            this.tabControlCadastro.SuspendLayout();
            this.tabPagCadastroCarro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(110, 361);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(252, 361);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(112, 23);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtBoxModelo
            // 
            this.txtBoxModelo.Location = new System.Drawing.Point(88, 13);
            this.txtBoxModelo.Name = "txtBoxModelo";
            this.txtBoxModelo.Size = new System.Drawing.Size(372, 20);
            this.txtBoxModelo.TabIndex = 2;
            // 
            // txtBoxFabricante
            // 
            this.txtBoxFabricante.Location = new System.Drawing.Point(88, 40);
            this.txtBoxFabricante.Name = "txtBoxFabricante";
            this.txtBoxFabricante.Size = new System.Drawing.Size(372, 20);
            this.txtBoxFabricante.TabIndex = 3;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(17, 13);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 6;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(17, 40);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(60, 13);
            this.lblFabricante.TabIndex = 7;
            this.lblFabricante.Text = "Fabricante:";
            // 
            // lblOpcionais
            // 
            this.lblOpcionais.AutoSize = true;
            this.lblOpcionais.Location = new System.Drawing.Point(17, 74);
            this.lblOpcionais.Name = "lblOpcionais";
            this.lblOpcionais.Size = new System.Drawing.Size(57, 13);
            this.lblOpcionais.TabIndex = 8;
            this.lblOpcionais.Text = "Opcionais:";
            // 
            // tabControlCadastro
            // 
            this.tabControlCadastro.Controls.Add(this.tabPagCadastroCarro);
            this.tabControlCadastro.Controls.Add(this.tabPageCadastroUsuário);
            this.tabControlCadastro.Location = new System.Drawing.Point(12, 12);
            this.tabControlCadastro.Name = "tabControlCadastro";
            this.tabControlCadastro.SelectedIndex = 0;
            this.tabControlCadastro.Size = new System.Drawing.Size(493, 426);
            this.tabControlCadastro.TabIndex = 10;
            // 
            // tabPagCadastroCarro
            // 
            this.tabPagCadastroCarro.Controls.Add(this.lblPortas);
            this.tabPagCadastroCarro.Controls.Add(this.comboBoxPortas);
            this.tabPagCadastroCarro.Controls.Add(this.checkListBoxOpcionais);
            this.tabPagCadastroCarro.Controls.Add(this.lblModelo);
            this.tabPagCadastroCarro.Controls.Add(this.btnLimpar);
            this.tabPagCadastroCarro.Controls.Add(this.btnSalvar);
            this.tabPagCadastroCarro.Controls.Add(this.txtBoxModelo);
            this.tabPagCadastroCarro.Controls.Add(this.lblOpcionais);
            this.tabPagCadastroCarro.Controls.Add(this.txtBoxFabricante);
            this.tabPagCadastroCarro.Controls.Add(this.lblFabricante);
            this.tabPagCadastroCarro.Location = new System.Drawing.Point(4, 22);
            this.tabPagCadastroCarro.Name = "tabPagCadastroCarro";
            this.tabPagCadastroCarro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagCadastroCarro.Size = new System.Drawing.Size(485, 400);
            this.tabPagCadastroCarro.TabIndex = 0;
            this.tabPagCadastroCarro.Text = "CADASTRO DE CARRO";
            this.tabPagCadastroCarro.UseVisualStyleBackColor = true;
            // 
            // lblPortas
            // 
            this.lblPortas.AutoSize = true;
            this.lblPortas.Location = new System.Drawing.Point(17, 183);
            this.lblPortas.Name = "lblPortas";
            this.lblPortas.Size = new System.Drawing.Size(40, 13);
            this.lblPortas.TabIndex = 11;
            this.lblPortas.Text = "Portas:";
            // 
            // comboBoxPortas
            // 
            this.comboBoxPortas.FormattingEnabled = true;
            this.comboBoxPortas.Items.AddRange(new object[] {
            "Duas portas",
            "Três portas",
            "Quatro portas",
            "Cinco portas"});
            this.comboBoxPortas.Location = new System.Drawing.Point(88, 183);
            this.comboBoxPortas.Name = "comboBoxPortas";
            this.comboBoxPortas.Size = new System.Drawing.Size(372, 21);
            this.comboBoxPortas.TabIndex = 10;
            // 
            // checkListBoxOpcionais
            // 
            this.checkListBoxOpcionais.FormattingEnabled = true;
            this.checkListBoxOpcionais.Items.AddRange(new object[] {
            "Airbag",
            "Ar-condicionado",
            "Direção hidráulica",
            "Freio ABS",
            "Vidros elétricos"});
            this.checkListBoxOpcionais.Location = new System.Drawing.Point(88, 74);
            this.checkListBoxOpcionais.Name = "checkListBoxOpcionais";
            this.checkListBoxOpcionais.Size = new System.Drawing.Size(372, 94);
            this.checkListBoxOpcionais.Sorted = true;
            this.checkListBoxOpcionais.TabIndex = 9;
            // 
            // tabPageCadastroUsuário
            // 
            this.tabPageCadastroUsuário.Location = new System.Drawing.Point(4, 22);
            this.tabPageCadastroUsuário.Name = "tabPageCadastroUsuário";
            this.tabPageCadastroUsuário.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastroUsuário.Size = new System.Drawing.Size(485, 400);
            this.tabPageCadastroUsuário.TabIndex = 1;
            this.tabPageCadastroUsuário.Text = "CADASTRO DE USUÁRIO";
            this.tabPageCadastroUsuário.UseVisualStyleBackColor = true;
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(this.tabControlCadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroUsuario";
            this.Text = "Form1";
            this.tabControlCadastro.ResumeLayout(false);
            this.tabPagCadastroCarro.ResumeLayout(false);
            this.tabPagCadastroCarro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtBoxModelo;
        private System.Windows.Forms.TextBox txtBoxFabricante;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Label lblOpcionais;
        private System.Windows.Forms.TabControl tabControlCadastro;
        private System.Windows.Forms.TabPage tabPagCadastroCarro;
        private System.Windows.Forms.TabPage tabPageCadastroUsuário;
        private System.Windows.Forms.CheckedListBox checkListBoxOpcionais;
        private System.Windows.Forms.Label lblPortas;
        private System.Windows.Forms.ComboBox comboBoxPortas;
    }
}

