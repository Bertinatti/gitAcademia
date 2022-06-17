namespace DesafioGaragem
{
    partial class frmConfiguracaoGaragem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracaoGaragem));
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.tbNovoPreco = new System.Windows.Forms.TextBox();
            this.lblVagas = new System.Windows.Forms.Label();
            this.tbVagasGaragem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblVagasAtuais = new System.Windows.Forms.Label();
            this.lblNumeroVagas = new System.Windows.Forms.Label();
            this.lblPrecoAtual = new System.Windows.Forms.Label();
            this.lblValorAtual = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(20, 125);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(146, 23);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(172, 125);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(146, 23);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(324, 125);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(146, 23);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(17, 67);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(81, 16);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Novo preço:";
            // 
            // tbNovoPreco
            // 
            this.tbNovoPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNovoPreco.Location = new System.Drawing.Point(20, 86);
            this.tbNovoPreco.Name = "tbNovoPreco";
            this.tbNovoPreco.Size = new System.Drawing.Size(223, 22);
            this.tbNovoPreco.TabIndex = 4;
            // 
            // lblVagas
            // 
            this.lblVagas.AutoSize = true;
            this.lblVagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVagas.Location = new System.Drawing.Point(246, 67);
            this.lblVagas.Name = "lblVagas";
            this.lblVagas.Size = new System.Drawing.Size(126, 16);
            this.lblVagas.TabIndex = 5;
            this.lblVagas.Text = "Vagas na garagem:";
            // 
            // tbVagasGaragem
            // 
            this.tbVagasGaragem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVagasGaragem.Location = new System.Drawing.Point(249, 86);
            this.tbVagasGaragem.Name = "tbVagasGaragem";
            this.tbVagasGaragem.Size = new System.Drawing.Size(218, 22);
            this.tbVagasGaragem.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblVagasAtuais);
            this.panel2.Controls.Add(this.lblNumeroVagas);
            this.panel2.Controls.Add(this.lblPrecoAtual);
            this.panel2.Controls.Add(this.lblValorAtual);
            this.panel2.Location = new System.Drawing.Point(20, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 32);
            this.panel2.TabIndex = 20;
            // 
            // lblVagasAtuais
            // 
            this.lblVagasAtuais.AutoSize = true;
            this.lblVagasAtuais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVagasAtuais.Location = new System.Drawing.Point(281, 7);
            this.lblVagasAtuais.Name = "lblVagasAtuais";
            this.lblVagasAtuais.Size = new System.Drawing.Size(89, 16);
            this.lblVagasAtuais.TabIndex = 17;
            this.lblVagasAtuais.Text = "Vagas atuais:";
            // 
            // lblNumeroVagas
            // 
            this.lblNumeroVagas.AutoSize = true;
            this.lblNumeroVagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroVagas.Location = new System.Drawing.Point(369, 7);
            this.lblNumeroVagas.Name = "lblNumeroVagas";
            this.lblNumeroVagas.Size = new System.Drawing.Size(21, 16);
            this.lblNumeroVagas.TabIndex = 18;
            this.lblNumeroVagas.Text = "00";
            // 
            // lblPrecoAtual
            // 
            this.lblPrecoAtual.AutoSize = true;
            this.lblPrecoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoAtual.Location = new System.Drawing.Point(54, 7);
            this.lblPrecoAtual.Name = "lblPrecoAtual";
            this.lblPrecoAtual.Size = new System.Drawing.Size(98, 16);
            this.lblPrecoAtual.TabIndex = 17;
            this.lblPrecoAtual.Text = "Preço atual: R$";
            // 
            // lblValorAtual
            // 
            this.lblValorAtual.AutoSize = true;
            this.lblValorAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAtual.Location = new System.Drawing.Point(151, 7);
            this.lblValorAtual.Name = "lblValorAtual";
            this.lblValorAtual.Size = new System.Drawing.Size(21, 16);
            this.lblValorAtual.TabIndex = 18;
            this.lblValorAtual.Text = "00";
            // 
            // frmConfiguracaoGaragem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 165);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbVagasGaragem);
            this.Controls.Add(this.lblVagas);
            this.Controls.Add(this.tbNovoPreco);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGravar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConfiguracaoGaragem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GARAGEM - Configurar valor e vagas.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConfiguracaoGaragem_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox tbNovoPreco;
        private System.Windows.Forms.Label lblVagas;
        private System.Windows.Forms.TextBox tbVagasGaragem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblVagasAtuais;
        private System.Windows.Forms.Label lblNumeroVagas;
        private System.Windows.Forms.Label lblPrecoAtual;
        private System.Windows.Forms.Label lblValorAtual;
    }
}