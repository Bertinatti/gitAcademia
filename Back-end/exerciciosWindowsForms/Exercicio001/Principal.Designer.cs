namespace Exercicio001
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairMenuItemArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarImpressoraMenuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.impressoraXMenuImpressora = new System.Windows.Forms.ToolStripMenuItem();
            this.automóvelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoMenuItem,
            this.cadastrarMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoMenuItem
            // 
            this.arquivoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarImpressoraMenuArquivo,
            this.arquivoSeparator,
            this.sairMenuItemArquivo});
            this.arquivoMenuItem.Name = "arquivoMenuItem";
            this.arquivoMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoMenuItem.Text = "Arquivo";
            // 
            // sairMenuItemArquivo
            // 
            this.sairMenuItemArquivo.Name = "sairMenuItemArquivo";
            this.sairMenuItemArquivo.Size = new System.Drawing.Size(192, 22);
            this.sairMenuItemArquivo.Text = "Sair";
            this.sairMenuItemArquivo.ToolTipText = "Sai da aplicação.";
            this.sairMenuItemArquivo.Click += new System.EventHandler(this.sairMenuItemArquivo_Click);
            // 
            // cadastrarMenuItem
            // 
            this.cadastrarMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.automóvelToolStripMenuItem});
            this.cadastrarMenuItem.Name = "cadastrarMenuItem";
            this.cadastrarMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarMenuItem.Text = "Cadastrar";
            this.cadastrarMenuItem.ToolTipText = "Ir para o cadastro do automóvel.";
            this.cadastrarMenuItem.Click += new System.EventHandler(this.cadastrarMenuItem_Click);
            // 
            // configurarImpressoraMenuArquivo
            // 
            this.configurarImpressoraMenuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impressoraXMenuImpressora});
            this.configurarImpressoraMenuArquivo.Enabled = false;
            this.configurarImpressoraMenuArquivo.Name = "configurarImpressoraMenuArquivo";
            this.configurarImpressoraMenuArquivo.Size = new System.Drawing.Size(192, 22);
            this.configurarImpressoraMenuArquivo.Text = "Configurar Impressora";
            this.configurarImpressoraMenuArquivo.ToolTipText = "Configura a impressora.";
            // 
            // arquivoSeparator
            // 
            this.arquivoSeparator.Name = "arquivoSeparator";
            this.arquivoSeparator.Size = new System.Drawing.Size(189, 6);
            // 
            // impressoraXMenuImpressora
            // 
            this.impressoraXMenuImpressora.Enabled = false;
            this.impressoraXMenuImpressora.Name = "impressoraXMenuImpressora";
            this.impressoraXMenuImpressora.Size = new System.Drawing.Size(180, 22);
            this.impressoraXMenuImpressora.Text = "Impressora X";
            // 
            // automóvelToolStripMenuItem
            // 
            this.automóvelToolStripMenuItem.Name = "automóvelToolStripMenuItem";
            this.automóvelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.automóvelToolStripMenuItem.Text = "Automóvel";
            this.automóvelToolStripMenuItem.Click += new System.EventHandler(this.automóvelToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Sistema de Cadastro de Automóveis";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairMenuItemArquivo;
        private System.Windows.Forms.ToolStripMenuItem cadastrarMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarImpressoraMenuArquivo;
        private System.Windows.Forms.ToolStripSeparator arquivoSeparator;
        private System.Windows.Forms.ToolStripMenuItem impressoraXMenuImpressora;
        private System.Windows.Forms.ToolStripMenuItem automóvelToolStripMenuItem;
    }
}