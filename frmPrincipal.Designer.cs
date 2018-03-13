namespace AppGroups
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
            this.menuFrmPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnArquivoFrmPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBackupFrmPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCadastroUserFrmPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCadastroFrmPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFuncionarioFrmPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnProdutoFrmPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCartaoFrmPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFinanceiroFrmPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnReceitaFrmPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDespesaFrmPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRelatorioFrmPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRelFuncionarioFrmPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRelProdutoFrmPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRelCartaoFrmPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRelReceitaFrmPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRelDespesaFrmPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFrmPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuFrmPrincipal
            // 
            this.menuFrmPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnArquivoFrmPrincipal,
            this.mnCadastroFrmPrincipal,
            this.mnFinanceiroFrmPrincipal,
            this.mnRelatorioFrmPrincipal});
            this.menuFrmPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuFrmPrincipal.Name = "menuFrmPrincipal";
            this.menuFrmPrincipal.Size = new System.Drawing.Size(623, 24);
            this.menuFrmPrincipal.TabIndex = 1;
            this.menuFrmPrincipal.Text = "menuStrip2";
            // 
            // mnArquivoFrmPrincipal
            // 
            this.mnArquivoFrmPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnBackupFrmPrincipal,
            this.mnCadastroUserFrmPrincipal});
            this.mnArquivoFrmPrincipal.Name = "mnArquivoFrmPrincipal";
            this.mnArquivoFrmPrincipal.Size = new System.Drawing.Size(61, 20);
            this.mnArquivoFrmPrincipal.Text = "Arquivo";
            // 
            // mnBackupFrmPrincipal
            // 
            this.mnBackupFrmPrincipal.Name = "mnBackupFrmPrincipal";
            this.mnBackupFrmPrincipal.Size = new System.Drawing.Size(185, 22);
            this.mnBackupFrmPrincipal.Text = "Backup";
            // 
            // mnCadastroUserFrmPrincipal
            // 
            this.mnCadastroUserFrmPrincipal.Name = "mnCadastroUserFrmPrincipal";
            this.mnCadastroUserFrmPrincipal.Size = new System.Drawing.Size(185, 22);
            this.mnCadastroUserFrmPrincipal.Text = "Cadastro de Usuários";
            this.mnCadastroUserFrmPrincipal.Click += new System.EventHandler(this.mnCadastroUserFrmPrincipal_Click);
            // 
            // mnCadastroFrmPrincipal
            // 
            this.mnCadastroFrmPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnFuncionarioFrmPrincipal,
            this.mnProdutoFrmPrincipal,
            this.mnCartaoFrmPrincipal});
            this.mnCadastroFrmPrincipal.Name = "mnCadastroFrmPrincipal";
            this.mnCadastroFrmPrincipal.Size = new System.Drawing.Size(66, 20);
            this.mnCadastroFrmPrincipal.Text = "Cadastro";
            this.mnCadastroFrmPrincipal.Click += new System.EventHandler(this.cadastrosToolStripMenuItem_Click);
            // 
            // mnFuncionarioFrmPrincipal
            // 
            this.mnFuncionarioFrmPrincipal.Name = "mnFuncionarioFrmPrincipal";
            this.mnFuncionarioFrmPrincipal.Size = new System.Drawing.Size(142, 22);
            this.mnFuncionarioFrmPrincipal.Text = "Funcionários";
            // 
            // mnProdutoFrmPrincipal
            // 
            this.mnProdutoFrmPrincipal.Name = "mnProdutoFrmPrincipal";
            this.mnProdutoFrmPrincipal.Size = new System.Drawing.Size(142, 22);
            this.mnProdutoFrmPrincipal.Text = "Produtos";
            // 
            // mnCartaoFrmPrincipal
            // 
            this.mnCartaoFrmPrincipal.Name = "mnCartaoFrmPrincipal";
            this.mnCartaoFrmPrincipal.Size = new System.Drawing.Size(142, 22);
            this.mnCartaoFrmPrincipal.Text = "Cartões";
            // 
            // mnFinanceiroFrmPrincipal
            // 
            this.mnFinanceiroFrmPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnReceitaFrmPrincipal,
            this.mnDespesaFrmPrincipal});
            this.mnFinanceiroFrmPrincipal.Name = "mnFinanceiroFrmPrincipal";
            this.mnFinanceiroFrmPrincipal.Size = new System.Drawing.Size(74, 20);
            this.mnFinanceiroFrmPrincipal.Text = "Financeiro";
            // 
            // mnReceitaFrmPrincipal
            // 
            this.mnReceitaFrmPrincipal.Name = "mnReceitaFrmPrincipal";
            this.mnReceitaFrmPrincipal.Size = new System.Drawing.Size(122, 22);
            this.mnReceitaFrmPrincipal.Text = "Receitas";
            // 
            // mnDespesaFrmPrincipal
            // 
            this.mnDespesaFrmPrincipal.Name = "mnDespesaFrmPrincipal";
            this.mnDespesaFrmPrincipal.Size = new System.Drawing.Size(122, 22);
            this.mnDespesaFrmPrincipal.Text = "Despesas";
            // 
            // mnRelatorioFrmPrincipal
            // 
            this.mnRelatorioFrmPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnRelFuncionarioFrmPrincipal,
            this.mnRelProdutoFrmPrincipal,
            this.mnRelCartaoFrmPrincipal,
            this.mnRelReceitaFrmPrincipal,
            this.mnRelDespesaFrmPrincipal});
            this.mnRelatorioFrmPrincipal.Name = "mnRelatorioFrmPrincipal";
            this.mnRelatorioFrmPrincipal.Size = new System.Drawing.Size(71, 20);
            this.mnRelatorioFrmPrincipal.Text = "Relatórios";
            // 
            // mnRelFuncionarioFrmPrincipal
            // 
            this.mnRelFuncionarioFrmPrincipal.Name = "mnRelFuncionarioFrmPrincipal";
            this.mnRelFuncionarioFrmPrincipal.Size = new System.Drawing.Size(142, 22);
            this.mnRelFuncionarioFrmPrincipal.Text = "Funcionários";
            // 
            // mnRelProdutoFrmPrincipal
            // 
            this.mnRelProdutoFrmPrincipal.Name = "mnRelProdutoFrmPrincipal";
            this.mnRelProdutoFrmPrincipal.Size = new System.Drawing.Size(142, 22);
            this.mnRelProdutoFrmPrincipal.Text = "Produtos";
            // 
            // mnRelCartaoFrmPrincipal
            // 
            this.mnRelCartaoFrmPrincipal.Name = "mnRelCartaoFrmPrincipal";
            this.mnRelCartaoFrmPrincipal.Size = new System.Drawing.Size(142, 22);
            this.mnRelCartaoFrmPrincipal.Text = "Cartões";
            // 
            // mnRelReceitaFrmPrincipal
            // 
            this.mnRelReceitaFrmPrincipal.Name = "mnRelReceitaFrmPrincipal";
            this.mnRelReceitaFrmPrincipal.Size = new System.Drawing.Size(142, 22);
            this.mnRelReceitaFrmPrincipal.Text = "Receitas";
            this.mnRelReceitaFrmPrincipal.Click += new System.EventHandler(this.aReceberToolStripMenuItem_Click);
            // 
            // mnRelDespesaFrmPrincipal
            // 
            this.mnRelDespesaFrmPrincipal.Name = "mnRelDespesaFrmPrincipal";
            this.mnRelDespesaFrmPrincipal.Size = new System.Drawing.Size(142, 22);
            this.mnRelDespesaFrmPrincipal.Text = "Despesas";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 321);
            this.Controls.Add(this.menuFrmPrincipal);
            this.Name = "frmPrincipal";
            this.Text = "Controle de Groups";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuFrmPrincipal.ResumeLayout(false);
            this.menuFrmPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuFrmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnCadastroFrmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnFuncionarioFrmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnProdutoFrmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnCartaoFrmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnArquivoFrmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnBackupFrmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnCadastroUserFrmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnFinanceiroFrmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnReceitaFrmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnDespesaFrmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnRelatorioFrmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnRelFuncionarioFrmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnRelProdutoFrmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnRelCartaoFrmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnRelReceitaFrmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnRelDespesaFrmPrincipal;
    }
}

