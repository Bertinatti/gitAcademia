namespace exerciciosVeiculos_EF
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
            this.btnGravarModelo = new System.Windows.Forms.Button();
            this.tbModelos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.divModelo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.divVeiculos = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGravarVeiculo = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbModeloVeiculo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgModelos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dgIdModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNomeModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.dgVeiculos = new System.Windows.Forms.DataGridView();
            this.dgIdVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgIdModeloVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNomeVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAnoVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divModelo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.divVeiculos.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgModelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGravarModelo
            // 
            this.btnGravarModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.btnGravarModelo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnGravarModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravarModelo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarModelo.ForeColor = System.Drawing.Color.White;
            this.btnGravarModelo.Location = new System.Drawing.Point(601, 121);
            this.btnGravarModelo.Name = "btnGravarModelo";
            this.btnGravarModelo.Size = new System.Drawing.Size(160, 53);
            this.btnGravarModelo.TabIndex = 0;
            this.btnGravarModelo.Text = "Salvar modelo";
            this.btnGravarModelo.UseVisualStyleBackColor = false;
            this.btnGravarModelo.Click += new System.EventHandler(this.btnGravarModelo_Click);
            // 
            // tbModelos
            // 
            this.tbModelos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModelos.ForeColor = System.Drawing.Color.Black;
            this.tbModelos.Location = new System.Drawing.Point(40, 142);
            this.tbModelos.Name = "tbModelos";
            this.tbModelos.Size = new System.Drawing.Size(376, 26);
            this.tbModelos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modelo:";
            // 
            // divModelo
            // 
            this.divModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.divModelo.Controls.Add(this.panel1);
            this.divModelo.Controls.Add(this.label1);
            this.divModelo.Controls.Add(this.dgModelos);
            this.divModelo.Controls.Add(this.btnGravarModelo);
            this.divModelo.Controls.Add(this.label7);
            this.divModelo.Controls.Add(this.tbModelos);
            this.divModelo.Dock = System.Windows.Forms.DockStyle.Left;
            this.divModelo.Location = new System.Drawing.Point(0, 0);
            this.divModelo.Name = "divModelo";
            this.divModelo.Size = new System.Drawing.Size(802, 747);
            this.divModelo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(153, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(492, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "CADASTRANDO - Modelo de veículo.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 60);
            this.panel1.TabIndex = 3;
            // 
            // divVeiculos
            // 
            this.divVeiculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.divVeiculos.Controls.Add(this.dgVeiculos);
            this.divVeiculos.Controls.Add(this.label8);
            this.divVeiculos.Controls.Add(this.panel3);
            this.divVeiculos.Controls.Add(this.label6);
            this.divVeiculos.Controls.Add(this.label5);
            this.divVeiculos.Controls.Add(this.label4);
            this.divVeiculos.Controls.Add(this.btnGravarVeiculo);
            this.divVeiculos.Controls.Add(this.tbModeloVeiculo);
            this.divVeiculos.Controls.Add(this.tbAno);
            this.divVeiculos.Controls.Add(this.tbNome);
            this.divVeiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divVeiculos.Location = new System.Drawing.Point(802, 0);
            this.divVeiculos.Name = "divVeiculos";
            this.divVeiculos.Size = new System.Drawing.Size(830, 747);
            this.divVeiculos.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(11, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(778, 60);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(153, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(492, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "CADASTRANDO - Modelo de veículo.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome:";
            // 
            // btnGravarVeiculo
            // 
            this.btnGravarVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.btnGravarVeiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnGravarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravarVeiculo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarVeiculo.ForeColor = System.Drawing.Color.White;
            this.btnGravarVeiculo.Location = new System.Drawing.Point(601, 193);
            this.btnGravarVeiculo.Name = "btnGravarVeiculo";
            this.btnGravarVeiculo.Size = new System.Drawing.Size(160, 53);
            this.btnGravarVeiculo.TabIndex = 0;
            this.btnGravarVeiculo.Text = "Salvar veículo";
            this.btnGravarVeiculo.UseVisualStyleBackColor = false;
            this.btnGravarVeiculo.Click += new System.EventHandler(this.btnGravarVeiculo_Click);
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.ForeColor = System.Drawing.Color.Black;
            this.tbNome.Location = new System.Drawing.Point(40, 142);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(376, 26);
            this.tbNome.TabIndex = 1;
            // 
            // tbAno
            // 
            this.tbAno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAno.ForeColor = System.Drawing.Color.Black;
            this.tbAno.Location = new System.Drawing.Point(40, 207);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(376, 26);
            this.tbAno.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(37, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ano:";
            // 
            // tbModeloVeiculo
            // 
            this.tbModeloVeiculo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModeloVeiculo.ForeColor = System.Drawing.Color.Black;
            this.tbModeloVeiculo.Location = new System.Drawing.Point(40, 272);
            this.tbModeloVeiculo.Name = "tbModeloVeiculo";
            this.tbModeloVeiculo.Size = new System.Drawing.Size(376, 26);
            this.tbModeloVeiculo.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(37, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Modelo:";
            // 
            // dgModelos
            // 
            this.dgModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgModelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgIdModelo,
            this.dgNomeModelo});
            this.dgModelos.Location = new System.Drawing.Point(40, 272);
            this.dgModelos.Name = "dgModelos";
            this.dgModelos.Size = new System.Drawing.Size(721, 408);
            this.dgModelos.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(37, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Modelo:";
            // 
            // dgIdModelo
            // 
            this.dgIdModelo.HeaderText = "Id do modelo:";
            this.dgIdModelo.Name = "dgIdModelo";
            this.dgIdModelo.Width = 300;
            // 
            // dgNomeModelo
            // 
            this.dgNomeModelo.HeaderText = "Nome do modelo:";
            this.dgNomeModelo.Name = "dgNomeModelo";
            this.dgNomeModelo.Width = 300;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(37, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Veiculo:";
            // 
            // dgVeiculos
            // 
            this.dgVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgIdVeiculo,
            this.dgIdModeloVeiculo,
            this.dgNomeVeiculo,
            this.dgAnoVeiculo});
            this.dgVeiculos.Location = new System.Drawing.Point(40, 354);
            this.dgVeiculos.Name = "dgVeiculos";
            this.dgVeiculos.Size = new System.Drawing.Size(721, 326);
            this.dgVeiculos.TabIndex = 5;
            // 
            // dgIdVeiculo
            // 
            this.dgIdVeiculo.HeaderText = "Id do veículo:";
            this.dgIdVeiculo.Name = "dgIdVeiculo";
            this.dgIdVeiculo.Width = 150;
            // 
            // dgIdModeloVeiculo
            // 
            this.dgIdModeloVeiculo.HeaderText = "Id do modelo:";
            this.dgIdModeloVeiculo.Name = "dgIdModeloVeiculo";
            this.dgIdModeloVeiculo.Width = 150;
            // 
            // dgNomeVeiculo
            // 
            this.dgNomeVeiculo.HeaderText = "Nome do veículo:";
            this.dgNomeVeiculo.Name = "dgNomeVeiculo";
            this.dgNomeVeiculo.Width = 150;
            // 
            // dgAnoVeiculo
            // 
            this.dgAnoVeiculo.HeaderText = "Ano do veículo:";
            this.dgAnoVeiculo.Name = "dgAnoVeiculo";
            this.dgAnoVeiculo.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1632, 747);
            this.Controls.Add(this.divVeiculos);
            this.Controls.Add(this.divModelo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.divModelo.ResumeLayout(false);
            this.divModelo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.divVeiculos.ResumeLayout(false);
            this.divVeiculos.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgModelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVeiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGravarModelo;
        private System.Windows.Forms.TextBox tbModelos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel divModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel divVeiculos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGravarVeiculo;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbModeloVeiculo;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.DataGridView dgModelos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNomeModelo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgVeiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdModeloVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNomeVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAnoVeiculo;
    }
}

