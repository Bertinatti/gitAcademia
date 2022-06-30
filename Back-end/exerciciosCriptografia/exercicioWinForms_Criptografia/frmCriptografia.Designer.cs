namespace exercicioWinForms_Criptografia
{
    partial class frmCriptografia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCriptografia));
            this.lblFrase = new System.Windows.Forms.Label();
            this.tbFrase = new System.Windows.Forms.TextBox();
            this.btnCriptografiaAssimetrica = new System.Windows.Forms.Button();
            this.lblFraseCriptografada = new System.Windows.Forms.Label();
            this.lblExibirFrase = new System.Windows.Forms.Label();
            this.btnDescriptografarAssimetrica = new System.Windows.Forms.Button();
            this.lblFraseDescriptografada = new System.Windows.Forms.Label();
            this.lblExibirDescriptografada = new System.Windows.Forms.Label();
            this.btnCriptografiaSimetrica = new System.Windows.Forms.Button();
            this.btnDescriptografiaSimetrica = new System.Windows.Forms.Button();
            this.lblChave = new System.Windows.Forms.Label();
            this.tbChave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase.ForeColor = System.Drawing.Color.White;
            this.lblFrase.Location = new System.Drawing.Point(31, 25);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(59, 18);
            this.lblFrase.TabIndex = 0;
            this.lblFrase.Text = "Frase:";
            // 
            // tbFrase
            // 
            this.tbFrase.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFrase.Location = new System.Drawing.Point(34, 47);
            this.tbFrase.Name = "tbFrase";
            this.tbFrase.Size = new System.Drawing.Size(390, 26);
            this.tbFrase.TabIndex = 1;
            // 
            // btnCriptografiaAssimetrica
            // 
            this.btnCriptografiaAssimetrica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnCriptografiaAssimetrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriptografiaAssimetrica.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriptografiaAssimetrica.ForeColor = System.Drawing.Color.White;
            this.btnCriptografiaAssimetrica.Location = new System.Drawing.Point(34, 187);
            this.btnCriptografiaAssimetrica.Name = "btnCriptografiaAssimetrica";
            this.btnCriptografiaAssimetrica.Size = new System.Drawing.Size(295, 50);
            this.btnCriptografiaAssimetrica.TabIndex = 2;
            this.btnCriptografiaAssimetrica.Text = "Criptografia - Assimétrica";
            this.btnCriptografiaAssimetrica.UseVisualStyleBackColor = true;
            this.btnCriptografiaAssimetrica.Click += new System.EventHandler(this.btnCriptografiaAssimetrica_Click);
            // 
            // lblFraseCriptografada
            // 
            this.lblFraseCriptografada.AutoSize = true;
            this.lblFraseCriptografada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraseCriptografada.ForeColor = System.Drawing.Color.White;
            this.lblFraseCriptografada.Location = new System.Drawing.Point(31, 104);
            this.lblFraseCriptografada.Name = "lblFraseCriptografada";
            this.lblFraseCriptografada.Size = new System.Drawing.Size(172, 18);
            this.lblFraseCriptografada.TabIndex = 0;
            this.lblFraseCriptografada.Text = "Frase criptografada:";
            // 
            // lblExibirFrase
            // 
            this.lblExibirFrase.AutoSize = true;
            this.lblExibirFrase.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExibirFrase.ForeColor = System.Drawing.Color.White;
            this.lblExibirFrase.Location = new System.Drawing.Point(209, 104);
            this.lblExibirFrase.Name = "lblExibirFrase";
            this.lblExibirFrase.Size = new System.Drawing.Size(13, 18);
            this.lblExibirFrase.TabIndex = 0;
            this.lblExibirFrase.Text = ".";
            // 
            // btnDescriptografarAssimetrica
            // 
            this.btnDescriptografarAssimetrica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnDescriptografarAssimetrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescriptografarAssimetrica.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescriptografarAssimetrica.ForeColor = System.Drawing.Color.White;
            this.btnDescriptografarAssimetrica.Location = new System.Drawing.Point(335, 187);
            this.btnDescriptografarAssimetrica.Name = "btnDescriptografarAssimetrica";
            this.btnDescriptografarAssimetrica.Size = new System.Drawing.Size(294, 50);
            this.btnDescriptografarAssimetrica.TabIndex = 2;
            this.btnDescriptografarAssimetrica.Text = "Descriptografia - Assimétrica";
            this.btnDescriptografarAssimetrica.UseVisualStyleBackColor = true;
            this.btnDescriptografarAssimetrica.Click += new System.EventHandler(this.btnDescriptografarAssimetrica_Click);
            // 
            // lblFraseDescriptografada
            // 
            this.lblFraseDescriptografada.AutoSize = true;
            this.lblFraseDescriptografada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraseDescriptografada.ForeColor = System.Drawing.Color.White;
            this.lblFraseDescriptografada.Location = new System.Drawing.Point(31, 138);
            this.lblFraseDescriptografada.Name = "lblFraseDescriptografada";
            this.lblFraseDescriptografada.Size = new System.Drawing.Size(201, 18);
            this.lblFraseDescriptografada.TabIndex = 0;
            this.lblFraseDescriptografada.Text = "Frase descriptografada:";
            // 
            // lblExibirDescriptografada
            // 
            this.lblExibirDescriptografada.AutoSize = true;
            this.lblExibirDescriptografada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExibirDescriptografada.ForeColor = System.Drawing.Color.White;
            this.lblExibirDescriptografada.Location = new System.Drawing.Point(238, 138);
            this.lblExibirDescriptografada.Name = "lblExibirDescriptografada";
            this.lblExibirDescriptografada.Size = new System.Drawing.Size(13, 18);
            this.lblExibirDescriptografada.TabIndex = 0;
            this.lblExibirDescriptografada.Text = ".";
            // 
            // btnCriptografiaSimetrica
            // 
            this.btnCriptografiaSimetrica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnCriptografiaSimetrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriptografiaSimetrica.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriptografiaSimetrica.ForeColor = System.Drawing.Color.White;
            this.btnCriptografiaSimetrica.Location = new System.Drawing.Point(34, 243);
            this.btnCriptografiaSimetrica.Name = "btnCriptografiaSimetrica";
            this.btnCriptografiaSimetrica.Size = new System.Drawing.Size(295, 50);
            this.btnCriptografiaSimetrica.TabIndex = 2;
            this.btnCriptografiaSimetrica.Text = "Criptografia - Simétrica";
            this.btnCriptografiaSimetrica.UseVisualStyleBackColor = true;
            this.btnCriptografiaSimetrica.Click += new System.EventHandler(this.btnCriptografiaSimetrica_Click);
            // 
            // btnDescriptografiaSimetrica
            // 
            this.btnDescriptografiaSimetrica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnDescriptografiaSimetrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescriptografiaSimetrica.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescriptografiaSimetrica.ForeColor = System.Drawing.Color.White;
            this.btnDescriptografiaSimetrica.Location = new System.Drawing.Point(335, 243);
            this.btnDescriptografiaSimetrica.Name = "btnDescriptografiaSimetrica";
            this.btnDescriptografiaSimetrica.Size = new System.Drawing.Size(294, 50);
            this.btnDescriptografiaSimetrica.TabIndex = 2;
            this.btnDescriptografiaSimetrica.Text = "Descriptografia - Simétrica";
            this.btnDescriptografiaSimetrica.UseVisualStyleBackColor = true;
            this.btnDescriptografiaSimetrica.Click += new System.EventHandler(this.btnDescriptografiaSimetrica_Click);
            // 
            // lblChave
            // 
            this.lblChave.AutoSize = true;
            this.lblChave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChave.ForeColor = System.Drawing.Color.White;
            this.lblChave.Location = new System.Drawing.Point(427, 25);
            this.lblChave.Name = "lblChave";
            this.lblChave.Size = new System.Drawing.Size(64, 18);
            this.lblChave.TabIndex = 0;
            this.lblChave.Text = "Chave:";
            // 
            // tbChave
            // 
            this.tbChave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChave.Location = new System.Drawing.Point(430, 47);
            this.tbChave.Name = "tbChave";
            this.tbChave.Size = new System.Drawing.Size(199, 26);
            this.tbChave.TabIndex = 1;
            // 
            // frmCriptografia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(659, 328);
            this.Controls.Add(this.btnDescriptografiaSimetrica);
            this.Controls.Add(this.btnDescriptografarAssimetrica);
            this.Controls.Add(this.btnCriptografiaSimetrica);
            this.Controls.Add(this.btnCriptografiaAssimetrica);
            this.Controls.Add(this.tbChave);
            this.Controls.Add(this.tbFrase);
            this.Controls.Add(this.lblExibirDescriptografada);
            this.Controls.Add(this.lblExibirFrase);
            this.Controls.Add(this.lblFraseDescriptografada);
            this.Controls.Add(this.lblChave);
            this.Controls.Add(this.lblFraseCriptografada);
            this.Controls.Add(this.lblFrase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCriptografia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRIPTOGRAFIA - Código criptografado.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.TextBox tbFrase;
        private System.Windows.Forms.Button btnCriptografiaAssimetrica;
        private System.Windows.Forms.Label lblFraseCriptografada;
        private System.Windows.Forms.Label lblExibirFrase;
        private System.Windows.Forms.Button btnDescriptografarAssimetrica;
        private System.Windows.Forms.Label lblFraseDescriptografada;
        private System.Windows.Forms.Label lblExibirDescriptografada;
        private System.Windows.Forms.Button btnCriptografiaSimetrica;
        private System.Windows.Forms.Button btnDescriptografiaSimetrica;
        private System.Windows.Forms.Label lblChave;
        private System.Windows.Forms.TextBox tbChave;
    }
}

