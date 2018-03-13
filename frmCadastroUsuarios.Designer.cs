namespace AppGroups
{
    partial class frmCadastroUsuarios
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.txtDica = new System.Windows.Forms.TextBox();
            this.lblResultadoAutentica = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblConfirmaSenha = new System.Windows.Forms.Label();
            this.lblDica = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(129, 19);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(217, 21);
            this.txtNome.TabIndex = 0;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(129, 49);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(217, 21);
            this.txtLogin.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(129, 81);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(217, 21);
            this.txtSenha.TabIndex = 2;
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Location = new System.Drawing.Point(129, 116);
            this.txtConfirmaSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.Size = new System.Drawing.Size(217, 21);
            this.txtConfirmaSenha.TabIndex = 3;
            // 
            // txtDica
            // 
            this.txtDica.Location = new System.Drawing.Point(129, 173);
            this.txtDica.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDica.Name = "txtDica";
            this.txtDica.Size = new System.Drawing.Size(217, 21);
            this.txtDica.TabIndex = 4;
            // 
            // lblResultadoAutentica
            // 
            this.lblResultadoAutentica.AutoSize = true;
            this.lblResultadoAutentica.Location = new System.Drawing.Point(112, 242);
            this.lblResultadoAutentica.Name = "lblResultadoAutentica";
            this.lblResultadoAutentica.Size = new System.Drawing.Size(0, 15);
            this.lblResultadoAutentica.TabIndex = 5;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(101, 329);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(91, 34);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(199, 329);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(91, 34);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(297, 329);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 34);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(14, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 15);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(14, 49);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(41, 15);
            this.lblLogin.TabIndex = 10;
            this.lblLogin.Text = "Login:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(14, 81);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(46, 15);
            this.lblSenha.TabIndex = 11;
            this.lblSenha.Text = "Senha:";
            // 
            // lblConfirmaSenha
            // 
            this.lblConfirmaSenha.AutoSize = true;
            this.lblConfirmaSenha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmaSenha.Location = new System.Drawing.Point(14, 116);
            this.lblConfirmaSenha.Name = "lblConfirmaSenha";
            this.lblConfirmaSenha.Size = new System.Drawing.Size(100, 15);
            this.lblConfirmaSenha.TabIndex = 12;
            this.lblConfirmaSenha.Text = "Confirma Senha:";
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDica.Location = new System.Drawing.Point(14, 176);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(35, 15);
            this.lblDica.TabIndex = 13;
            this.lblDica.Text = "Dica:";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(3, 329);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(91, 34);
            this.btnNovo.TabIndex = 14;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmCadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 377);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lblDica);
            this.Controls.Add(this.lblConfirmaSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.lblResultadoAutentica);
            this.Controls.Add(this.txtDica);
            this.Controls.Add(this.txtConfirmaSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtNome);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCadastroUsuarios";
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.frmCadastroUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.TextBox txtDica;
        private System.Windows.Forms.Label lblResultadoAutentica;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblConfirmaSenha;
        private System.Windows.Forms.Label lblDica;
        private System.Windows.Forms.Button btnNovo;
    }
}