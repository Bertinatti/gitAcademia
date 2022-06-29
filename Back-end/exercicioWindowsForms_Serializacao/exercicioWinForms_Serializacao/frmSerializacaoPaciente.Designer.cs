namespace exercicioWinForms_Serializacao
{
    partial class frmSerializacaoPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSerializacaoPaciente));
            this.btnSerializarXML = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSerializarSOAP = new System.Windows.Forms.Button();
            this.btnSerializarJSON = new System.Windows.Forms.Button();
            this.btnAdicionarPaciente = new System.Windows.Forms.Button();
            this.tbNomePaciente = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.tbDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.tbCPF = new System.Windows.Forms.MaskedTextBox();
            this.dgPacientes = new System.Windows.Forms.DataGridView();
            this.dgNomePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSerializarXML
            // 
            this.btnSerializarXML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSerializarXML.FlatAppearance.BorderSize = 0;
            this.btnSerializarXML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnSerializarXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerializarXML.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerializarXML.ForeColor = System.Drawing.Color.White;
            this.btnSerializarXML.Location = new System.Drawing.Point(0, 288);
            this.btnSerializarXML.Name = "btnSerializarXML";
            this.btnSerializarXML.Size = new System.Drawing.Size(157, 50);
            this.btnSerializarXML.TabIndex = 6;
            this.btnSerializarXML.Text = "Serializar XML";
            this.btnSerializarXML.UseVisualStyleBackColor = true;
            this.btnSerializarXML.Click += new System.EventHandler(this.btnSerializarXML_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSerializarSOAP);
            this.panel1.Controls.Add(this.btnSerializarJSON);
            this.panel1.Controls.Add(this.btnAdicionarPaciente);
            this.panel1.Controls.Add(this.btnSerializarXML);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 450);
            this.panel1.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.ForeColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(0, 400);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 50);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(0, 344);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 50);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Blue;
            this.panel5.ForeColor = System.Drawing.Color.Transparent;
            this.panel5.Location = new System.Drawing.Point(0, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3, 50);
            this.panel5.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 50);
            this.panel2.TabIndex = 2;
            // 
            // btnSerializarSOAP
            // 
            this.btnSerializarSOAP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSerializarSOAP.FlatAppearance.BorderSize = 0;
            this.btnSerializarSOAP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnSerializarSOAP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerializarSOAP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerializarSOAP.ForeColor = System.Drawing.Color.White;
            this.btnSerializarSOAP.Location = new System.Drawing.Point(0, 344);
            this.btnSerializarSOAP.Name = "btnSerializarSOAP";
            this.btnSerializarSOAP.Size = new System.Drawing.Size(157, 50);
            this.btnSerializarSOAP.TabIndex = 7;
            this.btnSerializarSOAP.Text = "Serializar SOAP";
            this.btnSerializarSOAP.UseVisualStyleBackColor = true;
            // 
            // btnSerializarJSON
            // 
            this.btnSerializarJSON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSerializarJSON.FlatAppearance.BorderSize = 0;
            this.btnSerializarJSON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnSerializarJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerializarJSON.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerializarJSON.ForeColor = System.Drawing.Color.White;
            this.btnSerializarJSON.Location = new System.Drawing.Point(0, 400);
            this.btnSerializarJSON.Name = "btnSerializarJSON";
            this.btnSerializarJSON.Size = new System.Drawing.Size(157, 50);
            this.btnSerializarJSON.TabIndex = 7;
            this.btnSerializarJSON.Text = "Serializar JSON";
            this.btnSerializarJSON.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarPaciente
            // 
            this.btnAdicionarPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdicionarPaciente.FlatAppearance.BorderSize = 0;
            this.btnAdicionarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnAdicionarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarPaciente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarPaciente.Location = new System.Drawing.Point(0, 3);
            this.btnAdicionarPaciente.Name = "btnAdicionarPaciente";
            this.btnAdicionarPaciente.Size = new System.Drawing.Size(157, 50);
            this.btnAdicionarPaciente.TabIndex = 5;
            this.btnAdicionarPaciente.Text = "Adicionar";
            this.btnAdicionarPaciente.UseVisualStyleBackColor = true;
            this.btnAdicionarPaciente.Click += new System.EventHandler(this.btnAdicionarPaciente_Click);
            // 
            // tbNomePaciente
            // 
            this.tbNomePaciente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomePaciente.Location = new System.Drawing.Point(207, 44);
            this.tbNomePaciente.Name = "tbNomePaciente";
            this.tbNomePaciente.Size = new System.Drawing.Size(551, 26);
            this.tbNomePaciente.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(204, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(161, 18);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome do paciente: ";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.ForeColor = System.Drawing.Color.White;
            this.lblDataNascimento.Location = new System.Drawing.Point(204, 91);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(172, 18);
            this.lblDataNascimento.TabIndex = 3;
            this.lblDataNascimento.Text = "Data de nascimento:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.White;
            this.lblCPF.Location = new System.Drawing.Point(464, 91);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(46, 18);
            this.lblCPF.TabIndex = 3;
            this.lblCPF.Text = "CPF:";
            // 
            // tbDataNascimento
            // 
            this.tbDataNascimento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDataNascimento.Location = new System.Drawing.Point(207, 112);
            this.tbDataNascimento.Mask = "00/00/0000";
            this.tbDataNascimento.Name = "tbDataNascimento";
            this.tbDataNascimento.Size = new System.Drawing.Size(254, 26);
            this.tbDataNascimento.TabIndex = 1;
            this.tbDataNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // tbCPF
            // 
            this.tbCPF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCPF.Location = new System.Drawing.Point(467, 112);
            this.tbCPF.Mask = "000,000,000-00";
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(291, 26);
            this.tbCPF.TabIndex = 2;
            this.tbCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgPacientes
            // 
            this.dgPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgNomePaciente,
            this.dgDataNascimento,
            this.dgCPF});
            this.dgPacientes.Location = new System.Drawing.Point(207, 177);
            this.dgPacientes.Name = "dgPacientes";
            this.dgPacientes.Size = new System.Drawing.Size(551, 235);
            this.dgPacientes.TabIndex = 3;
            // 
            // dgNomePaciente
            // 
            this.dgNomePaciente.HeaderText = "Nome do paciente:";
            this.dgNomePaciente.Name = "dgNomePaciente";
            this.dgNomePaciente.Width = 180;
            // 
            // dgDataNascimento
            // 
            this.dgDataNascimento.HeaderText = "Data de nascimento:";
            this.dgDataNascimento.Name = "dgDataNascimento";
            this.dgDataNascimento.Width = 150;
            // 
            // dgCPF
            // 
            this.dgCPF.HeaderText = "CPF:";
            this.dgCPF.Name = "dgCPF";
            this.dgCPF.Width = 150;
            // 
            // frmSerializacaoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgPacientes);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.tbDataNascimento);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.tbNomePaciente);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSerializacaoPaciente";
            this.Text = "SERIALIZAÇÃO - Paciente.";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSerializarXML;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSerializarSOAP;
        private System.Windows.Forms.Button btnSerializarJSON;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbNomePaciente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox tbDataNascimento;
        private System.Windows.Forms.MaskedTextBox tbCPF;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAdicionarPaciente;
        private System.Windows.Forms.DataGridView dgPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNomePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCPF;
    }
}

