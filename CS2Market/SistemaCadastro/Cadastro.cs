using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaCadastro
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnUserCadastro_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            string senhaHash = Biblioteca.makeHash(txtSenhaLogin.Text);
            u.Nome = txtUserLogin.Text;
            u.Senha = senhaHash;


            ConectaBanco conecta = new ConectaBanco();
            bool retorno = conecta.insereUsuarios(u);
            if (retorno == true)
            {
                MessageBox.Show("Dados Inseridos com Sucesso :)");
            }
            else
                MessageBox.Show("Erro :(" + conecta.mensagem);

            FrmLogin formLogin = new FrmLogin();
            this.Hide();
            formLogin.ShowDialog();
            this.Close();

           
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            FrmLogin formLogin = new FrmLogin();
            this.Hide();
            formLogin.ShowDialog();
            this.Close();
        }
    }
}
