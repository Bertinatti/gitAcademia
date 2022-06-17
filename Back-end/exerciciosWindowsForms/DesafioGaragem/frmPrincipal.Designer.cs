namespace DesafioGaragem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnEntrada = new System.Windows.Forms.Button();
            this.timerHoras = new System.Windows.Forms.Timer(this.components);
            this.btnSaida = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.tbPlacaVeiculo = new System.Windows.Forms.TextBox();
            this.blHora = new System.Windows.Forms.Label();
            this.mtbHora = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dgEntradaVeiculos = new System.Windows.Forms.DataGridView();
            this.dgPlacaVeiculoEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgHoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVeiculosEntrada = new System.Windows.Forms.Label();
            this.dgSaidaVeiculos = new System.Windows.Forms.DataGridView();
            this.dgPlacaVeiculoSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTempoPermanencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgValoCobrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSaidaVeiculos = new System.Windows.Forms.Label();
            this.lblVagas = new System.Windows.Forms.Label();
            this.lblNumeroVagas = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfiguracao = new System.Windows.Forms.Button();
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntradaVeiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaidaVeiculos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEntrada
            // 
            this.btnEntrada.Location = new System.Drawing.Point(16, 480);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(146, 23);
            this.btnEntrada.TabIndex = 2;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // timerHoras
            // 
            this.timerHoras.Enabled = true;
            this.timerHoras.Tick += new System.EventHandler(this.timerHoras_Tick);
            // 
            // btnSaida
            // 
            this.btnSaida.Location = new System.Drawing.Point(168, 480);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(146, 23);
            this.btnSaida.TabIndex = 3;
            this.btnSaida.Text = "Saída";
            this.btnSaida.UseVisualStyleBackColor = true;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.lblDia);
            this.panel1.Location = new System.Drawing.Point(311, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 22);
            this.panel1.TabIndex = 6;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(11, 2);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(51, 16);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "lblHora";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(70, 2);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(42, 16);
            this.lblDia.TabIndex = 1;
            this.lblDia.Text = "lblDia";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(13, 13);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(110, 16);
            this.lblPlaca.TabIndex = 7;
            this.lblPlaca.Text = "Placa do veículo:";
            // 
            // tbPlacaVeiculo
            // 
            this.tbPlacaVeiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPlacaVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlacaVeiculo.Location = new System.Drawing.Point(16, 33);
            this.tbPlacaVeiculo.MaxLength = 7;
            this.tbPlacaVeiculo.Name = "tbPlacaVeiculo";
            this.tbPlacaVeiculo.Size = new System.Drawing.Size(183, 22);
            this.tbPlacaVeiculo.TabIndex = 8;
            // 
            // blHora
            // 
            this.blHora.AutoSize = true;
            this.blHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blHora.Location = new System.Drawing.Point(202, 14);
            this.blHora.Name = "blHora";
            this.blHora.Size = new System.Drawing.Size(40, 16);
            this.blHora.TabIndex = 9;
            this.blHora.Text = "Hora:";
            // 
            // mtbHora
            // 
            this.mtbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbHora.Location = new System.Drawing.Point(205, 33);
            this.mtbHora.Mask = "00:00";
            this.mtbHora.Name = "mtbHora";
            this.mtbHora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbHora.Size = new System.Drawing.Size(100, 22);
            this.mtbHora.TabIndex = 11;
            this.mtbHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbHora.ValidatingType = typeof(System.DateTime);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(320, 480);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(146, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dgEntradaVeiculos
            // 
            this.dgEntradaVeiculos.AllowUserToAddRows = false;
            this.dgEntradaVeiculos.AllowUserToDeleteRows = false;
            this.dgEntradaVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntradaVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgPlacaVeiculoEntrada,
            this.dgDataEntrada,
            this.dgHoraEntrada});
            this.dgEntradaVeiculos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgEntradaVeiculos.Location = new System.Drawing.Point(16, 90);
            this.dgEntradaVeiculos.Name = "dgEntradaVeiculos";
            this.dgEntradaVeiculos.ReadOnly = true;
            this.dgEntradaVeiculos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgEntradaVeiculos.Size = new System.Drawing.Size(450, 150);
            this.dgEntradaVeiculos.TabIndex = 13;
            this.dgEntradaVeiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEntradaVeiculos_CellContentClick);
            // 
            // dgPlacaVeiculoEntrada
            // 
            this.dgPlacaVeiculoEntrada.HeaderText = "Placa do veículo";
            this.dgPlacaVeiculoEntrada.Name = "dgPlacaVeiculoEntrada";
            this.dgPlacaVeiculoEntrada.ReadOnly = true;
            this.dgPlacaVeiculoEntrada.Width = 130;
            // 
            // dgDataEntrada
            // 
            this.dgDataEntrada.HeaderText = "Data da entrada";
            this.dgDataEntrada.Name = "dgDataEntrada";
            this.dgDataEntrada.ReadOnly = true;
            this.dgDataEntrada.Width = 145;
            // 
            // dgHoraEntrada
            // 
            this.dgHoraEntrada.HeaderText = "Hora da Entrada";
            this.dgHoraEntrada.Name = "dgHoraEntrada";
            this.dgHoraEntrada.ReadOnly = true;
            this.dgHoraEntrada.Width = 130;
            // 
            // lblVeiculosEntrada
            // 
            this.lblVeiculosEntrada.AutoSize = true;
            this.lblVeiculosEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculosEntrada.Location = new System.Drawing.Point(13, 71);
            this.lblVeiculosEntrada.Name = "lblVeiculosEntrada";
            this.lblVeiculosEntrada.Size = new System.Drawing.Size(138, 16);
            this.lblVeiculosEntrada.TabIndex = 14;
            this.lblVeiculosEntrada.Text = "Veículos na garagem:";
            // 
            // dgSaidaVeiculos
            // 
            this.dgSaidaVeiculos.AllowUserToAddRows = false;
            this.dgSaidaVeiculos.AllowUserToDeleteRows = false;
            this.dgSaidaVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSaidaVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgPlacaVeiculoSaida,
            this.dgTempoPermanencia,
            this.dgValoCobrado});
            this.dgSaidaVeiculos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgSaidaVeiculos.Location = new System.Drawing.Point(16, 280);
            this.dgSaidaVeiculos.Name = "dgSaidaVeiculos";
            this.dgSaidaVeiculos.ReadOnly = true;
            this.dgSaidaVeiculos.Size = new System.Drawing.Size(450, 150);
            this.dgSaidaVeiculos.TabIndex = 15;
            this.dgSaidaVeiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSaidaVeiculos_CellContentClick);
            // 
            // dgPlacaVeiculoSaida
            // 
            this.dgPlacaVeiculoSaida.HeaderText = "Placa do veículo";
            this.dgPlacaVeiculoSaida.Name = "dgPlacaVeiculoSaida";
            this.dgPlacaVeiculoSaida.ReadOnly = true;
            this.dgPlacaVeiculoSaida.Width = 130;
            // 
            // dgTempoPermanencia
            // 
            this.dgTempoPermanencia.HeaderText = "Tempo de permanência";
            this.dgTempoPermanencia.Name = "dgTempoPermanencia";
            this.dgTempoPermanencia.ReadOnly = true;
            this.dgTempoPermanencia.Width = 145;
            // 
            // dgValoCobrado
            // 
            this.dgValoCobrado.HeaderText = "Valor cobrado";
            this.dgValoCobrado.Name = "dgValoCobrado";
            this.dgValoCobrado.ReadOnly = true;
            this.dgValoCobrado.Width = 130;
            // 
            // lblSaidaVeiculos
            // 
            this.lblSaidaVeiculos.AutoSize = true;
            this.lblSaidaVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaidaVeiculos.Location = new System.Drawing.Point(12, 261);
            this.lblSaidaVeiculos.Name = "lblSaidaVeiculos";
            this.lblSaidaVeiculos.Size = new System.Drawing.Size(135, 16);
            this.lblSaidaVeiculos.TabIndex = 16;
            this.lblSaidaVeiculos.Text = "Histórico de veículos:";
            // 
            // lblVagas
            // 
            this.lblVagas.AutoSize = true;
            this.lblVagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVagas.Location = new System.Drawing.Point(192, 6);
            this.lblVagas.Name = "lblVagas";
            this.lblVagas.Size = new System.Drawing.Size(50, 16);
            this.lblVagas.TabIndex = 17;
            this.lblVagas.Text = "Vagas:";
            // 
            // lblNumeroVagas
            // 
            this.lblNumeroVagas.AutoSize = true;
            this.lblNumeroVagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroVagas.Location = new System.Drawing.Point(240, 6);
            this.lblNumeroVagas.Name = "lblNumeroVagas";
            this.lblNumeroVagas.Size = new System.Drawing.Size(21, 16);
            this.lblNumeroVagas.TabIndex = 18;
            this.lblNumeroVagas.Text = "00";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnConfiguracao);
            this.panel2.Controls.Add(this.lblVagas);
            this.panel2.Controls.Add(this.lblNumeroVagas);
            this.panel2.Location = new System.Drawing.Point(16, 439);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 32);
            this.panel2.TabIndex = 19;
            // 
            // btnConfiguracao
            // 
            this.btnConfiguracao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfiguracao.BackgroundImage")));
            this.btnConfiguracao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfiguracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracao.Location = new System.Drawing.Point(409, -1);
            this.btnConfiguracao.Name = "btnConfiguracao";
            this.btnConfiguracao.Size = new System.Drawing.Size(40, 32);
            this.btnConfiguracao.TabIndex = 20;
            this.btnConfiguracao.UseVisualStyleBackColor = true;
            this.btnConfiguracao.Click += new System.EventHandler(this.btnConfiguracao_Click);
            // 
            // imageListIcons
            // 
            this.imageListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcons.ImageStream")));
            this.imageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcons.Images.SetKeyName(0, "icone_configuracao.png");
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(482, 519);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblSaidaVeiculos);
            this.Controls.Add(this.dgSaidaVeiculos);
            this.Controls.Add(this.lblVeiculosEntrada);
            this.Controls.Add(this.dgEntradaVeiculos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.mtbHora);
            this.Controls.Add(this.blHora);
            this.Controls.Add(this.tbPlacaVeiculo);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSaida);
            this.Controls.Add(this.btnEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GARAGEM - Entrada e saída de veículos.";
            this.Activated += new System.EventHandler(this.frmPrincipal_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntradaVeiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaidaVeiculos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Timer timerHoras;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox tbPlacaVeiculo;
        private System.Windows.Forms.Label blHora;
        private System.Windows.Forms.MaskedTextBox mtbHora;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dgEntradaVeiculos;
        private System.Windows.Forms.Label lblVeiculosEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPlacaVeiculoEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDataEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgHoraEntrada;
        private System.Windows.Forms.DataGridView dgSaidaVeiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPlacaVeiculoSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTempoPermanencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgValoCobrado;
        private System.Windows.Forms.Label lblSaidaVeiculos;
        private System.Windows.Forms.Label lblVagas;
        private System.Windows.Forms.Label lblNumeroVagas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageListIcons;
        private System.Windows.Forms.Button btnConfiguracao;
    }
}

