using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ConectaBanco conecta = new ConectaBanco();
            if (conecta.verifica(txtUserLogin.Text, txtSenhaLogin.Text) == true)
            {

                Sistema sistema = new Sistema();
                this.Hide();
                sistema.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Dados incorretos!" + conecta.mensagem);
            }
               
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtSenhaLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUserCadastro_Click(object sender, EventArgs e)
        {
            Cadastro formCadastro = new Cadastro();
            this.Hide();
            formCadastro.ShowDialog();
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
