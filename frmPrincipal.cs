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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void mnCadastroUserFrmPrincipal_Click(object sender, EventArgs e)
        {
            frmCadastroUsuarios carregaForm = new frmCadastroUsuarios();
            carregaForm.Show();
        }
    }
}
