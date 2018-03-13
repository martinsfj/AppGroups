using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGroups
{
    class Usuario
    {
        private String nome;
        private String login;
        private String senha;
        private String confirmaSenha;
        private String dica;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public String Login
        {
            get { return login; }
            set { login = value; }
        }
        public String Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        public String ConfirmaSenha
        {
            get { return confirmaSenha; }
            set { confirmaSenha = value; }
        }
        public String Dica
        {
            get { return dica; }
            set { dica = value; }
        }

        public void Cadastrar(String nome, String login, String senha, String confirmaSenha, String dica)
        {

            if (nome == "" || login == "" || senha == "" || confirmaSenha == "" || dica == "")
            {
                MessageBox.Show("Teste");
            }
            else
            {

                if (senha == confirmaSenha)
                {
                    this.nome = nome.Trim();
                    this.login = login.Trim();
                    this.senha = senha.Trim();
                    this.confirmaSenha = confirmaSenha.Trim();
                    this.dica = dica.Trim();

                    OleDbConnection dbConnection = new OleDbConnection();
                    OleDbCommand insereRegistro = dbConnection.CreateCommand();

                    insereRegistro.CommandText = "INSERT INTO Usuarios (Nome, Login, Senha, ConfirmaSenha, Dica)" +
                        "VALUES (@nome, @login, @senha, @confirmaSenha, @dica)";

                    MessageBox.Show(this.nome + " " + this.login + " " + this.senha + " " + this.confirmaSenha + " " + this.dica);
                }

            }

        }


    }
}
