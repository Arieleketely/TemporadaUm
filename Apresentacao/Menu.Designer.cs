namespace Apresentacao
{
    partial class Menu
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
            this.statusStripPrincipal = new System.Windows.Forms.StatusStrip();
            this.LabelVersao = new System.Windows.Forms.ToolStripStatusLabel();
            this.cadastroPessoaMenuPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.pesssoaMenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.eventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarMarcaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirMarcaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarMarcaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarMarcaçãoPorEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTodasMarcaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStripPrincipal.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripPrincipal
            // 
            this.statusStripPrincipal.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.statusStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelVersao});
            this.statusStripPrincipal.Location = new System.Drawing.Point(0, 715);
            this.statusStripPrincipal.Name = "statusStripPrincipal";
            this.statusStripPrincipal.Size = new System.Drawing.Size(1081, 22);
            this.statusStripPrincipal.TabIndex = 2;
            this.statusStripPrincipal.Text = "statusStrip1";
            // 
            // LabelVersao
            // 
            this.LabelVersao.Name = "LabelVersao";
            this.LabelVersao.Size = new System.Drawing.Size(59, 17);
            this.LabelVersao.Text = "Versao 1.0";
            // 
            // cadastroPessoaMenuPrincipal
            // 
            this.cadastroPessoaMenuPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesssoaMenuCadastro,
            this.eventoToolStripMenuItem,
            this.localToolStripMenuItem});
            this.cadastroPessoaMenuPrincipal.Name = "cadastroPessoaMenuPrincipal";
            this.cadastroPessoaMenuPrincipal.Size = new System.Drawing.Size(66, 20);
            this.cadastroPessoaMenuPrincipal.Text = "&Cadastro";
            this.cadastroPessoaMenuPrincipal.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // pesssoaMenuCadastro
            // 
            this.pesssoaMenuCadastro.Name = "pesssoaMenuCadastro";
            this.pesssoaMenuCadastro.Size = new System.Drawing.Size(115, 22);
            this.pesssoaMenuCadastro.Text = "Pesssoa";
            this.pesssoaMenuCadastro.Click += new System.EventHandler(this.pesssoaMenuCadastro_Click);
            // 
            // eventoToolStripMenuItem
            // 
            this.eventoToolStripMenuItem.Name = "eventoToolStripMenuItem";
            this.eventoToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.eventoToolStripMenuItem.Text = "Evento";
            // 
            // localToolStripMenuItem
            // 
            this.localToolStripMenuItem.Name = "localToolStripMenuItem";
            this.localToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.localToolStripMenuItem.Text = "Local";
            // 
            // marcaçãoToolStripMenuItem
            // 
            this.marcaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarMarcaçãoToolStripMenuItem,
            this.excluirMarcaçãoToolStripMenuItem,
            this.editarMarcaçãoToolStripMenuItem,
            this.consultarMarcaçãoPorEventoToolStripMenuItem,
            this.consultarTodasMarcaçõesToolStripMenuItem});
            this.marcaçãoToolStripMenuItem.Name = "marcaçãoToolStripMenuItem";
            this.marcaçãoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.marcaçãoToolStripMenuItem.Text = "&Marcação";
            this.marcaçãoToolStripMenuItem.Click += new System.EventHandler(this.marcaçãoToolStripMenuItem_Click);
            // 
            // realizarMarcaçãoToolStripMenuItem
            // 
            this.realizarMarcaçãoToolStripMenuItem.Name = "realizarMarcaçãoToolStripMenuItem";
            this.realizarMarcaçãoToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.realizarMarcaçãoToolStripMenuItem.Text = "Realizar marcação";
            // 
            // excluirMarcaçãoToolStripMenuItem
            // 
            this.excluirMarcaçãoToolStripMenuItem.Name = "excluirMarcaçãoToolStripMenuItem";
            this.excluirMarcaçãoToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.excluirMarcaçãoToolStripMenuItem.Text = "Excluir marcação";
            // 
            // editarMarcaçãoToolStripMenuItem
            // 
            this.editarMarcaçãoToolStripMenuItem.Name = "editarMarcaçãoToolStripMenuItem";
            this.editarMarcaçãoToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.editarMarcaçãoToolStripMenuItem.Text = "Editar Marcação";
            // 
            // consultarMarcaçãoPorEventoToolStripMenuItem
            // 
            this.consultarMarcaçãoPorEventoToolStripMenuItem.Name = "consultarMarcaçãoPorEventoToolStripMenuItem";
            this.consultarMarcaçãoPorEventoToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.consultarMarcaçãoPorEventoToolStripMenuItem.Text = "Consultar Marcação por evento";
            // 
            // consultarTodasMarcaçõesToolStripMenuItem
            // 
            this.consultarTodasMarcaçõesToolStripMenuItem.Name = "consultarTodasMarcaçõesToolStripMenuItem";
            this.consultarTodasMarcaçõesToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.consultarTodasMarcaçõesToolStripMenuItem.Text = "Consultar todas marcações";
            // 
            // sairPrincipal
            // 
            this.sairPrincipal.Name = "sairPrincipal";
            this.sairPrincipal.Size = new System.Drawing.Size(38, 20);
            this.sairPrincipal.Text = "&Sair";
            this.sairPrincipal.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroPessoaMenuPrincipal,
            this.marcaçãoToolStripMenuItem,
            this.sairPrincipal});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1081, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 737);
            this.Controls.Add(this.statusStripPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.statusStripPrincipal.ResumeLayout(false);
            this.statusStripPrincipal.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StatusStrip statusStripPrincipal;
        private ToolStripStatusLabel LabelVersao;
        private ToolStripMenuItem cadastroPessoaMenuPrincipal;
        private ToolStripMenuItem pesssoaMenuCadastro;
        private ToolStripMenuItem eventoToolStripMenuItem;
        private ToolStripMenuItem localToolStripMenuItem;
        private ToolStripMenuItem marcaçãoToolStripMenuItem;
        private ToolStripMenuItem realizarMarcaçãoToolStripMenuItem;
        private ToolStripMenuItem excluirMarcaçãoToolStripMenuItem;
        private ToolStripMenuItem editarMarcaçãoToolStripMenuItem;
        private ToolStripMenuItem consultarMarcaçãoPorEventoToolStripMenuItem;
        private ToolStripMenuItem consultarTodasMarcaçõesToolStripMenuItem;
        private ToolStripMenuItem sairPrincipal;
        private MenuStrip menuStrip1;
    }
}