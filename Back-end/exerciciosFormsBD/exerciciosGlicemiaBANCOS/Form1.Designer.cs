namespace exerciciosGlicemiaBANCOS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView_medidasGlicemias = new System.Windows.Forms.ListView();
            this.chIdGlicemia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clValorGlicemia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDataMedicao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNomePaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConectar = new System.Windows.Forms.Button();
            this.lblIdMedicao = new System.Windows.Forms.Label();
            this.tbIdMedicao = new System.Windows.Forms.TextBox();
            this.lblValorGlicemia = new System.Windows.Forms.Label();
            this.tbValorGlicemia = new System.Windows.Forms.TextBox();
            this.lblDataMedicao = new System.Windows.Forms.Label();
            this.lblIdPaciente = new System.Windows.Forms.Label();
            this.tbIdPaciente = new System.Windows.Forms.TextBox();
            this.tbDataMedicao = new System.Windows.Forms.MaskedTextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_medidasGlicemias
            // 
            this.listView_medidasGlicemias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chIdGlicemia,
            this.clValorGlicemia,
            this.clDataMedicao,
            this.clNomePaciente});
            this.listView_medidasGlicemias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_medidasGlicemias.HideSelection = false;
            this.listView_medidasGlicemias.Location = new System.Drawing.Point(25, 125);
            this.listView_medidasGlicemias.Name = "listView_medidasGlicemias";
            this.listView_medidasGlicemias.Size = new System.Drawing.Size(583, 213);
            this.listView_medidasGlicemias.TabIndex = 0;
            this.listView_medidasGlicemias.UseCompatibleStateImageBehavior = false;
            this.listView_medidasGlicemias.View = System.Windows.Forms.View.Details;
            // 
            // chIdGlicemia
            // 
            this.chIdGlicemia.Text = "Id medição:";
            this.chIdGlicemia.Width = 135;
            // 
            // clValorGlicemia
            // 
            this.clValorGlicemia.Text = "Valor glicemia:";
            this.clValorGlicemia.Width = 135;
            // 
            // clDataMedicao
            // 
            this.clDataMedicao.Text = "Data da medição:";
            this.clDataMedicao.Width = 135;
            // 
            // clNomePaciente
            // 
            this.clNomePaciente.Text = "Nome do paciente:";
            this.clNomePaciente.Width = 135;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(397, 415);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(142, 23);
            this.btnConectar.TabIndex = 1;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // lblIdMedicao
            // 
            this.lblIdMedicao.AutoSize = true;
            this.lblIdMedicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMedicao.Location = new System.Drawing.Point(22, 25);
            this.lblIdMedicao.Name = "lblIdMedicao";
            this.lblIdMedicao.Size = new System.Drawing.Size(77, 16);
            this.lblIdMedicao.TabIndex = 2;
            this.lblIdMedicao.Text = "Id medição:";
            // 
            // tbIdMedicao
            // 
            this.tbIdMedicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdMedicao.Location = new System.Drawing.Point(25, 44);
            this.tbIdMedicao.Name = "tbIdMedicao";
            this.tbIdMedicao.Size = new System.Drawing.Size(141, 22);
            this.tbIdMedicao.TabIndex = 3;
            // 
            // lblValorGlicemia
            // 
            this.lblValorGlicemia.AutoSize = true;
            this.lblValorGlicemia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorGlicemia.Location = new System.Drawing.Point(169, 25);
            this.lblValorGlicemia.Name = "lblValorGlicemia";
            this.lblValorGlicemia.Size = new System.Drawing.Size(96, 16);
            this.lblValorGlicemia.TabIndex = 4;
            this.lblValorGlicemia.Text = "Valor glicemia:";
            // 
            // tbValorGlicemia
            // 
            this.tbValorGlicemia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorGlicemia.Location = new System.Drawing.Point(172, 44);
            this.tbValorGlicemia.Name = "tbValorGlicemia";
            this.tbValorGlicemia.Size = new System.Drawing.Size(141, 22);
            this.tbValorGlicemia.TabIndex = 5;
            // 
            // lblDataMedicao
            // 
            this.lblDataMedicao.AutoSize = true;
            this.lblDataMedicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataMedicao.Location = new System.Drawing.Point(316, 25);
            this.lblDataMedicao.Name = "lblDataMedicao";
            this.lblDataMedicao.Size = new System.Drawing.Size(114, 16);
            this.lblDataMedicao.TabIndex = 6;
            this.lblDataMedicao.Text = "Data da medição:";
            // 
            // lblIdPaciente
            // 
            this.lblIdPaciente.AutoSize = true;
            this.lblIdPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPaciente.Location = new System.Drawing.Point(463, 24);
            this.lblIdPaciente.Name = "lblIdPaciente";
            this.lblIdPaciente.Size = new System.Drawing.Size(76, 16);
            this.lblIdPaciente.TabIndex = 8;
            this.lblIdPaciente.Text = "Id paciente:";
            // 
            // tbIdPaciente
            // 
            this.tbIdPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdPaciente.Location = new System.Drawing.Point(466, 44);
            this.tbIdPaciente.Name = "tbIdPaciente";
            this.tbIdPaciente.Size = new System.Drawing.Size(142, 22);
            this.tbIdPaciente.TabIndex = 9;
            // 
            // tbDataMedicao
            // 
            this.tbDataMedicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDataMedicao.Location = new System.Drawing.Point(319, 44);
            this.tbDataMedicao.Mask = "00/00/0000";
            this.tbDataMedicao.Name = "tbDataMedicao";
            this.tbDataMedicao.Size = new System.Drawing.Size(141, 22);
            this.tbDataMedicao.TabIndex = 10;
            this.tbDataMedicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDataMedicao.ValidatingType = typeof(System.DateTime);
            // 
            // panelTop
            // 
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Location = new System.Drawing.Point(25, 78);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(583, 33);
            this.panelTop.TabIndex = 11;
            // 
            // panelBottom
            // 
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Location = new System.Drawing.Point(25, 359);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(583, 33);
            this.panelBottom.TabIndex = 11;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(101, 415);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(142, 23);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(249, 415);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(142, 23);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 462);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.tbDataMedicao);
            this.Controls.Add(this.tbIdPaciente);
            this.Controls.Add(this.lblIdPaciente);
            this.Controls.Add(this.lblDataMedicao);
            this.Controls.Add(this.tbValorGlicemia);
            this.Controls.Add(this.lblValorGlicemia);
            this.Controls.Add(this.tbIdMedicao);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.lblIdMedicao);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.listView_medidasGlicemias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GLICEMIA - Banco de dados.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_medidasGlicemias;
        private System.Windows.Forms.ColumnHeader chIdGlicemia;
        private System.Windows.Forms.ColumnHeader clValorGlicemia;
        private System.Windows.Forms.ColumnHeader clDataMedicao;
        private System.Windows.Forms.ColumnHeader clNomePaciente;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label lblIdMedicao;
        private System.Windows.Forms.TextBox tbIdMedicao;
        private System.Windows.Forms.Label lblValorGlicemia;
        private System.Windows.Forms.TextBox tbValorGlicemia;
        private System.Windows.Forms.Label lblDataMedicao;
        private System.Windows.Forms.Label lblIdPaciente;
        private System.Windows.Forms.TextBox tbIdPaciente;
        private System.Windows.Forms.MaskedTextBox tbDataMedicao;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnRemover;
    }
}

