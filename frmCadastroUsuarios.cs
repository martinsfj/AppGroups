using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGroups
{
    public partial class frmCadastroUsuarios : Form
    {
        public frmCadastroUsuarios()
        {
            InitializeComponent();
        }

        private void frmCadastroUsuarios_Load(object sender, EventArgs e)
        {

            carregaBotaoGravar();
            travaCampos();
            txtSenha.PasswordChar = '*';
            txtConfirmaSenha.PasswordChar = '*';

        }

        public void carregaBotaoGravar()
        {
            btnEditar.Enabled = false;
            btnGravar.Enabled = false;
        }

        public void carregaBotaoNovo()
        {
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
        }

        public void carregaBotaoEditar()
        {
            btnNovo.Enabled = false;
            btnGravar.Enabled = false;

        }

        public void travaCampos()
        {
            txtConfirmaSenha.Enabled = false;
            txtDica.Enabled = false;
            txtLogin.Enabled = false;
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
        }

        public void destravaCampos()
        {
            txtConfirmaSenha.Enabled = true;
            txtDica.Enabled = true;
            txtLogin.Enabled = true;
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            destravaCampos();
            carregaBotaoNovo();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Usuario dados = new Usuario();

            dados.Cadastrar(txtNome.Text, txtLogin.Text, txtSenha.Text, txtConfirmaSenha.Text, txtDica.Text);

        }
    }

}
